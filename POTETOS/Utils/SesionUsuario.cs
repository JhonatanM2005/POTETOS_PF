using POTETOS.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POTETOS.Utils
{
    public sealed class SesionUsuario
    {
        private static SesionUsuario _instance = null;
        private static readonly object _lockSesion = new object();

        public Usuario UsuarioActual { get; private set; }
        public bool EstaAutenticado => UsuarioActual != null;

        private SesionUsuario() { }

        public static SesionUsuario Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockSesion)
                    {
                        if (_instance == null)
                            _instance = new SesionUsuario();
                    }
                }
                return _instance;
            }
        }

        public void IniciarSesion(Usuario usuario)
        {
            UsuarioActual = usuario;
        }

        public void CerrarSesion()
        {
            UsuarioActual = null;
        }

        public bool TienePermiso(string tipoRequerido)
        {
            if (!EstaAutenticado) return false;

            // El administrador tiene todos los permisos
            if (UsuarioActual.TipoUsuario == "Administrador") return true;

            // Verificar permiso específico
            return UsuarioActual.TipoUsuario == tipoRequerido;
        }
    }
}
