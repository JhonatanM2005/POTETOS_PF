using POTETOS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POTETOS
{
    public partial class frm_login : Form
    {
        private List<cls_users> Users;
        public frm_login(List<cls_users> Users)
        {
            InitializeComponent();
            this.Users = Users;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_help_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Comuniquese con el administrador del sistema para sus credenciales.", "¿Necesitas ayuda?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void b_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (username == "Admin" && password == "Admin123")
            {
                AdminScreen();
            }
            else
            {
                string userRole = ValidateUser(username, password);

                if (userRole != "Invalid")
                {
                    switch (userRole)
                    {
                        case "Administrador":
                            AdminScreen();
                            break;
                        case "Chef":
                            ChefScreen(userRole);
                            break;
                        case "Mesero":
                            MeseroScreen(userRole);
                            break;
                        case "Cajero":
                            CajeroScreen(userRole);
                            break;
                        case "Repartidor":
                            RepartidorScreen(userRole);
                            break;
                    }
                }
                else
                {
                    lbl_messageone.Text = "Usuario y/o contraseña incorrectos";
                    lbl_messagetwo.Text = "Intente nuevamente";
                }
            }
        }

        private string ValidateUser(string username, string password)
        {
            foreach (cls_users user in Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return user.UserType;
                }
            }
            return "Invalid"; 
        }

        private void AdminScreen()
        {
           
            frm_admin frm_Admin = new frm_admin(Users);
            frm_Admin.Show();


            this.Close();

        }

        private void ChefScreen(string userRole)
        {

            frm_index frm_Index = new frm_index(Users, userRole);
            frm_Index.Show();

            this.Close();

        }

        private void MeseroScreen(string userRole)
        {

            frm_index frm_Index = new frm_index(Users, userRole);
            frm_Index.Show();

            this.Close();

        }

        private void CajeroScreen(string userRole)
        {

            frm_index frm_Index = new frm_index(Users, userRole);
            frm_Index.Show();

            this.Close();

        }

        private void RepartidorScreen(string userRole)
        {

            frm_index frm_Index = new frm_index(Users, userRole);
            frm_Index.Show();

            this.Close();

        }

        private void lbl_messagetwo_Click(object sender, EventArgs e)
        {

        }
    }
}
