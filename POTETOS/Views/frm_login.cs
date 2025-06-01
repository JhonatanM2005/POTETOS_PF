using POTETOS.Properties;
using POTETOS.Controllers;
using POTETOS.Models.Data;
using POTETOS.Utils;
using System;
using System.Windows.Forms;

namespace POTETOS       
{
    public partial class frm_login : Form
    {
        private readonly UsuarioController _usuarioController;

        public frm_login()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comuniquese con el administrador del sistema para sus credenciales.", 
                          "¿Necesitas ayuda?", 
                          MessageBoxButtons.OK, 
                          MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = tb_username.Text;
                string contrasena = tb_password.Text;

                if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasena))
                {
                    lbl_messageone.Text = "Por favor ingrese usuario y contraseña";
                    lbl_messagetwo.Text = "Todos los campos son requeridos";
                    return;
                }

                var usuario = _usuarioController.ValidarLogin(nombreUsuario, contrasena);

                if (usuario != null)
                {
                    SesionUsuario.Instance.IniciarSesion(usuario);

                    switch (usuario.TipoUsuario)
                    {
                        case "Administrador":
                            NavigateToScreen(usuario.TipoUsuario, true);
                            break;
                        case "Chef":
                        case "Mesero":
                            NavigateToScreen(usuario.TipoUsuario);
                            break;
                        default:
                            lbl_messageone.Text = "Tipo de usuario no reconocido";
                            lbl_messagetwo.Text = "Contacte al administrador";
                            break;
                    }
                }
                else
                {
                    lbl_messageone.Text = "Usuario y/o contraseña incorrectos";
                    lbl_messagetwo.Text = "Intente nuevamente";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar iniciar sesión: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void NavigateToScreen(string tipoUsuario, bool isAdmin = false)
        {
            try
            {
                var usuarios = _usuarioController.ObtenerTodosLosUsuarios();
                Form nextForm;

                if (isAdmin)
                {
                    nextForm = new frm_admin();
                }
                else
                {
                    nextForm = new frm_index(tipoUsuario);
                }

                nextForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la pantalla: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}
