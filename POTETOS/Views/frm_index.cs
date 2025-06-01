using POTETOS.Properties;
using POTETOS.Controllers;
using POTETOS.Utils;
using POTETOS.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POTETOS
{
    public partial class frm_index : Form
    {
        private readonly UsuarioController _usuarioController;
        private readonly MesaController _mesaController;
        private readonly string _tipoUsuario;
        private readonly Usuario _usuarioActual;
        private readonly Dictionary<Button, Mesa> _mesas = new Dictionary<Button, Mesa>();
        private readonly List<Pedido> _pedidosActivos = new List<Pedido>();

        public frm_index(string tipoUsuario)
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();
            _mesaController = new MesaController();
            _tipoUsuario = tipoUsuario;
            _usuarioActual = SesionUsuario.Instance.UsuarioActual;
            ConfigurarPermisos();
            InicializarMesas();
        }

        private void ConfigurarPermisos()
        {
            try
            {
                // Configurar visibilidad de botones según el tipo de usuario
                switch (_tipoUsuario)
                {
                    case "Chef":
                        b_tables.Visible = true;
                        break;
                    case "Mesero":
                        b_menu.Visible = true;
                        b_tables.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar permisos: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarMesas()
        {
            // Inicializar las mesas con sus botones correspondientes
            _mesas.Add(b_table1, new Mesa { IdMesa = 1, NumeroMesa = 1, Estado = "Libre" });
            _mesas.Add(b_table2, new Mesa { IdMesa = 2, NumeroMesa = 2, Estado = "Libre" });
            _mesas.Add(b_table3, new Mesa { IdMesa = 3, NumeroMesa = 3, Estado = "Libre" });
            _mesas.Add(b_table4, new Mesa { IdMesa = 4, NumeroMesa = 4, Estado = "Libre" });

            ActualizarVisualizacionMesas();
        }

        private void frm_index_Load(object sender, EventArgs e)
        {
            try
            {
                // Mostrar información del usuario actual
                lbl_user.Text = $"{_usuarioActual.NombreCompleto} - {_tipoUsuario}";

                // Inicializar con el panel home visible
                MostrarPanel("home");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarPanel(string panel)
        {
            pnl_home.Visible = panel == "home";
            pnl_menu.Visible = panel == "menu";
            pnl_tables.Visible = panel == "tables";
            pnl_about.Visible = panel == "about";

            // Actualizar indicador de posición
            Button botonActivo = null;
            switch (panel)
            {
                case "home": botonActivo = b_home; break;
                case "menu": botonActivo = b_menu; break;
                case "tables": botonActivo = b_tables; break;
                case "about": botonActivo = b_about; break;
            }

            if (botonActivo != null)
            {
                pnl_positiononbtn.Height = botonActivo.Height;
                pnl_positiononbtn.Top = botonActivo.Top;
            }
        }

        private void b_home_Click(object sender, EventArgs e)
        {
            MostrarPanel("home");
        }

        private void b_menu_Click(object sender, EventArgs e)
        {
            MostrarPanel("menu");
        }

        private void b_tables_Click(object sender, EventArgs e)
        {
            MostrarPanel("tables");
        }

        private void b_deliverys_Click(object sender, EventArgs e)
        {
            MostrarPanel("deliverys");
        }

        private void b_about_Click(object sender, EventArgs e)
        {
            MostrarPanel("about");
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            try
            {
                LiberarTodasLasMesas(); // <-- Añadido aquí
                SesionUsuario.Instance.CerrarSesion();
                var loginForm = new frm_login();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar sesión: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Gestión de mesas
        private void GestionarMesa(Button botonMesa)
        {
            if (!SesionUsuario.Instance.TienePermiso("Mesero"))
            {
                MessageBox.Show("No tiene permisos para gestionar mesas.",
                              "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mesa = _mesas[botonMesa];

            switch (mesa.Estado)
            {
                case "Atendida":
                    
                    if (MessageBox.Show($"¿Desea liberar la mesa {mesa.NumeroMesa}?",
                        "Liberar Mesa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mesa.Estado = "Libre";
                        _mesaController.ActualizarMesa(mesa); // Actualizar estado en la base de datos
                        FinalizarPedido(mesa);
                    }
                    break;

                case "Libre":
                    if (MessageBox.Show($"¿Desea ocupar la mesa {mesa.NumeroMesa}?",
                        "Ocupar Mesa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mesa.Estado = "Ocupada";
                        CrearNuevoPedido(mesa);
                        _mesaController.ActualizarMesa(mesa); // Actualizar estado en la base de datos
                    }
                    MostrarDetallePedido(mesa);
                    break;

                case "Ocupada":
                    if (MessageBox.Show($"¿Desea marcar la mesa {mesa.NumeroMesa} como atendida?",
                        "Atender Mesa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mesa.Estado = "Atendida";
                        _mesaController.ActualizarMesa(mesa); // Actualizar estado en la base de datos
                    }
                    break;
            }

            ActualizarVisualizacionMesas();
        }

        private void ActualizarVisualizacionMesas()
        {
            foreach (var kvp in _mesas)
            {
                var boton = kvp.Key;
                var mesa = kvp.Value;

                switch (mesa.Estado)
                {
                    case "Libre":
                        boton.BackColor = Color.FromArgb(6, 1, 51); // Color original
                        break;
                    case "Ocupada":
                        boton.BackColor = Color.FromArgb(242, 186, 82); // Naranja
                        break;
                    case "Atendida":
                        boton.BackColor = Color.FromArgb(100, 149, 237); // Azul
                        break;
                }
            }
        }

        private void CrearNuevoPedido(Mesa mesa)
        {
            var nuevoPedido = new Pedido
            {
                IdMesa = mesa.IdMesa,
                IdMesero = _usuarioActual.IdUsuario,
                Fecha = DateTime.Now,
                Estado = "En cocina"
            };

            _pedidosActivos.Add(nuevoPedido);
            // Aquí se agregaría la lógica para guardar el pedido en la base de datos
        }

        private void MostrarDetallePedido(Mesa mesa)
        {
            var pedido = _pedidosActivos.FirstOrDefault(p => p.IdMesa == mesa.IdMesa);
            if (pedido != null)
            {
                MessageBox.Show(
                    $"Mesa: {mesa.NumeroMesa}\n" +
                    $"Estado: {mesa.Estado}\n" +
                    $"Pedido: {pedido.IdPedido}\n" +
                    $"Mesero: {_usuarioActual.NombreCompleto}\n" +
                    $"Estado del pedido: {pedido.Estado}",
                    "Detalle de Mesa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void FinalizarPedido(Mesa mesa)
        {
            var pedido = _pedidosActivos.FirstOrDefault(p => p.IdMesa == mesa.IdMesa);
            if (pedido != null)
            {
                pedido.Estado = "Entregado";
                _pedidosActivos.Remove(pedido);
                // Aquí se agregaría la lógica para actualizar el pedido en la base de datos
            }
        }

        private void b_table1_Click(object sender, EventArgs e)
        {
            GestionarMesa(b_table1);
        }

        private void b_table2_Click(object sender, EventArgs e)
        {
            GestionarMesa(b_table2);
        }

        private void b_table3_Click(object sender, EventArgs e)
        {
            GestionarMesa(b_table3);
        }

        private void b_table4_Click(object sender, EventArgs e)
        {
            GestionarMesa(b_table4);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                SesionUsuario.Instance.CerrarSesion();
               
            }
        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void LiberarTodasLasMesas()
        {
            foreach (var kvp in _mesas)
            {
                var mesa = kvp.Value;
                if (mesa.Estado != "Libre")
                {
                    mesa.Estado = "Libre";
                    // Actualiza el estado en la base de datos usando el método correcto
                    _mesaController.ActualizarMesa(mesa);
                    // También actualiza el estado en la base de datos directamente si es necesario
                    
                    FinalizarPedido(mesa);
                }
            }
            ActualizarVisualizacionMesas();
        }
    }
}
