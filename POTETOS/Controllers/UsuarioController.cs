using POTETOS.Models.Data;
using POTETOS.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POTETOS.Controllers
{
    public class UsuarioController
    {
        private UsuarioModel usuarioModel;

        public UsuarioController()
        {
            usuarioModel = new UsuarioModel();
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            try
            {
                return usuarioModel.ObtenerTodos();
            }
            catch (Exception ex)
            {
                // Log del error
                throw new Exception("Error al obtener usuarios: " + ex.Message);
            }
        }

        public bool CrearUsuario(Usuario usuario)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrEmpty(usuario.NombreUsuario))
                    throw new ArgumentException("El nombre de usuario es requerido");

                if (string.IsNullOrEmpty(usuario.Contrasena))
                    throw new ArgumentException("La contraseña es requerida");

                if (string.IsNullOrEmpty(usuario.TipoUsuario))
                    throw new ArgumentException("El tipo de usuario es requerido");

                return usuarioModel.Insertar(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear usuario: " + ex.Message);
            }
        }

        public bool ActualizarUsuario(Usuario usuario)
        {
            try
            {
                // Validaciones
                if (usuario.IdUsuario <= 0)
                    throw new ArgumentException("ID de usuario inválido");

                return usuarioModel.Actualizar(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario: " + ex.Message);
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {
            try
            {
                if (idUsuario <= 0)
                    throw new ArgumentException("ID de usuario inválido");

                return usuarioModel.Eliminar(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar usuario: " + ex.Message);
            }
        }

        public Usuario ValidarLogin(string nombreUsuario, string contrasena)
        {
            try
            {
                if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasena))
                    return null;

                return usuarioModel.ValidarCredenciales(nombreUsuario, contrasena);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en validación de login: " + ex.Message);
            }
        }

        
    }
}
