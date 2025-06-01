using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using POTETOS.Controllers;
using POTETOS.Properties;
using POTETOS.Utils;

namespace POTETOS.Properties
{
    public partial class frm_admin : Form
    {
        private readonly UsuarioController _usuarioController;

        public frm_admin()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();
        }

        private void frm_admin_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                var usuarios = _usuarioController.ObtenerTodosLosUsuarios();
                dgv_users.DataSource = null;
                dgv_users.DataSource = usuarios;
                dgv_users.Columns["IdUsuario"].Visible = false; // Ocultar columna IdUsuario
                dgv_users.Columns["Contrasena"].Visible = false; // Ocultar columna Contrasena
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Usuario> BuscarUsuario(string identificacion)
        {
            try
            {
                return _usuarioController.ObtenerTodosLosUsuarios()
                    .Where(u => u.Identificacion == identificacion).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar usuario: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Usuario>();
            }
        }

        private bool UsuarioExiste(string identificacion, string nombreUsuario)
        {
            try
            {
                var usuarios = _usuarioController.ObtenerTodosLosUsuarios();
                return usuarios.Any(u => u.Identificacion == identificacion ||
                                      u.NombreUsuario == nombreUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar usuario: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ValidarCampos(string identificacion, string nombreCompleto, string telefono,
                                string nombreUsuario, string tipoUsuario, string contrasena)
        {
            return !string.IsNullOrEmpty(identificacion) &&
                   !string.IsNullOrEmpty(nombreCompleto) &&
                   !string.IsNullOrEmpty(telefono) &&
                   !string.IsNullOrEmpty(nombreUsuario) &&
                   !string.IsNullOrEmpty(tipoUsuario) &&
                   !string.IsNullOrEmpty(contrasena);
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                string identificacion = tb_ident.Text;
                string nombreCompleto = tb_fullname.Text;
                string telefono = tb_phone.Text;
                string nombreUsuario = tb_username.Text;
                string tipoUsuario = cb_userType.Text;
                string contrasena = tb_password.Text;

                if (ValidarCampos(identificacion, nombreCompleto, telefono,
                                nombreUsuario, tipoUsuario, contrasena))
                {
                    if (!UsuarioExiste(identificacion, nombreUsuario))
                    {
                        var usuario = new Usuario
                        {
                            Identificacion = identificacion,
                            NombreCompleto = nombreCompleto,
                            Telefono = telefono,
                            NombreUsuario = nombreUsuario,
                            TipoUsuario = tipoUsuario,
                            Contrasena = contrasena
                        };

                        if (_usuarioController.CrearUsuario(usuario))
                        {
                            lbl_message.Text = $"El empleado fue creado exitosamente con el rol: {tipoUsuario}.";
                            CargarUsuarios();
                            LimpiarCampos();
                        }
                    }
                    else
                    {
                        lbl_message.Text = $"El empleado con identificación {identificacion} o usuario {nombreUsuario} ¡YA EXISTE!";
                    }
                }
                else
                {
                    lbl_message.Text = "Por favor, ingrese los datos. Hay 1 o más campos sin llenar.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar usuario: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_ident.Text))
            {
                var encontrados = BuscarUsuario(tb_ident.Text);
                if (encontrados.Count > 0)
                {
                    var usuario = encontrados[0];
                    tb_fullname.Text = usuario.NombreCompleto;
                    tb_phone.Text = usuario.Telefono;
                    tb_username.Text = usuario.NombreUsuario;
                    cb_userType.Text = usuario.TipoUsuario;
                    tb_password.Text = usuario.Contrasena;

                    lbl_message.Text = "Empleado encontrado. Información cargada en los cuadros de texto.";
                }
                else
                {
                    lbl_message.Text = $"La identificación {tb_ident.Text} no está registrada en el sistema.";
                }
            }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tb_ident.Text))
                {
                    var usuarios = BuscarUsuario(tb_ident.Text);
                    if (usuarios.Count > 0)
                    {
                        if (MessageBox.Show($"¿Está seguro de eliminar el usuario del empleado {tb_ident.Text}?",
                            "Borrar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (_usuarioController.EliminarUsuario(usuarios[0].IdUsuario))
                            {
                                lbl_message.Text = $"El empleado con identificación {tb_ident.Text} fue borrado del sistema.";
                                LimpiarCampos();
                                CargarUsuarios();
                            }
                        }
                    }
                    else
                    {
                        lbl_message.Text = $"El empleado con identificación {tb_ident.Text} no se encuentra.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            tb_ident.Clear();
            tb_fullname.Clear();
            tb_phone.Clear();
            tb_username.Clear();
            cb_userType.Text = "";
            tb_password.Clear();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            var loginForm = new frm_login();
            loginForm.Show();
            this.Close();
        }

        private void lbl_message_Click(object sender, EventArgs e)
        {
            lbl_message.Text = "";
        }

        private void cb_userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tb_ident.Text))
                {
                    var usuarios = BuscarUsuario(tb_ident.Text);
                    if (usuarios.Count > 0)
                    {
                        string identificacion = tb_ident.Text;
                        string nombreCompleto = tb_fullname.Text;
                        string telefono = tb_phone.Text;
                        string nombreUsuario = tb_username.Text;
                        string tipoUsuario = cb_userType.Text;
                        string contrasena = tb_password.Text;

                        if (ValidarCampos(identificacion, nombreCompleto, telefono,
                                        nombreUsuario, tipoUsuario, contrasena))
                        {
                            var usuarioActualizado = new Usuario
                            {
                                IdUsuario = usuarios[0].IdUsuario,
                                Identificacion = identificacion,
                                NombreCompleto = nombreCompleto,
                                Telefono = telefono,
                                NombreUsuario = nombreUsuario,
                                TipoUsuario = tipoUsuario,
                                Contrasena = contrasena
                            };

                            if (_usuarioController.ActualizarUsuario(usuarioActualizado))
                            {
                                lbl_message.Text = "El empleado fue actualizado exitosamente.";
                                CargarUsuarios();
                                LimpiarCampos();
                            }
                        }
                        else
                        {
                            lbl_message.Text = "Por favor, ingrese todos los datos. Hay uno o más campos sin llenar.";
                        }
                    }
                    else
                    {
                        lbl_message.Text = $"El empleado con identificación {tb_ident.Text} no se encuentra.";
                    }
                }
                else
                {
                    lbl_message.Text = "Por favor, ingrese una identificación para buscar el empleado a editar.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar usuario: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
