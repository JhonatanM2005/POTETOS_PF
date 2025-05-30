using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POTETOS.Properties
{
    public partial class frm_admin : Form
    {
        public List <cls_users> listUsers = new List <cls_users> ();
        public frm_admin(List<cls_users> users)
        {
            InitializeComponent();
            listUsers = users; 
        }

        private void frm_admin_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = listUsers;
        }

        public List<cls_users> SearchUser(string ident)
        {
            
            return listUsers.Where(user => user.Ident == ident).ToList();

        }

        private bool UserExists(string ident, string username)
        {
            return listUsers.Any(user => user.Ident == ident || user.Username == username);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool Check(String ident, string fullname, string phone, string username, string usertype, string password) 
        {
            return (ident != "" && fullname != "" && phone !="" && username !="" && usertype !="" && password !="");
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            string mident = tb_ident.Text;
            string mfullname = tb_fullname.Text;
            string mphone = tb_phone.Text;
            string musername = tb_username.Text;
            string musertype = cb_userType.Text;
            string mpassword = tb_password.Text;

            if (Check(mident, mfullname, mphone, musername, musertype, mpassword))
            {
              
                if (!UserExists(mident, musername))
                {
              
                    cls_users user = new cls_users
                    {
                        Ident = mident,
                        Fullname = mfullname,
                        Phone = mphone,
                        Username = musername,
                        UserType = musertype,
                        Password = mpassword
                    };

                    listUsers.Add(user);

                    lbl_message.Text = $"El empleado fue creado exitosamente con el rol: {musertype}.";

                    UserRefresh();
                }
                else
                {
                    lbl_message.Text = $"El empleado con identificacion {mident} o usuario {musername}. ¡YA EXISTE!";
                }
            }
            else
            {
                lbl_message.Text = "Por favor, ingrese los datos. Hay 1 o más campos sin llenar.";
            }

        }
        private void UserRefresh()
        {
            dgv_users.DataSource = null;
            dgv_users.DataSource = listUsers;
        }

        private void cb_userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_phone_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ident_Click(object sender, EventArgs e)
        {

        }

        private void lbl_userType_Click(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }

        private void lbl_loading_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            frm_login frm_Login = new frm_login(listUsers);
            frm_Login.Show();


            this.Close();
        }

        private void lbl_message_Click(object sender, EventArgs e)
        {
            lbl_message.Text = " ";
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_ident.Text))
            {
                List<cls_users> found = SearchUser(tb_ident.Text);
                if (found.Count > 0)
                {
                    tb_fullname.Text = found[0].Fullname;
                    tb_phone.Text = found[0].Phone;
                    tb_username.Text = found[0].Username;
                    cb_userType.Text = found[0].UserType;
                    tb_password.Text = found[0].Password;

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
            if (!string.IsNullOrEmpty(tb_ident.Text))
            {
                int indexFound = listUsers.FindIndex(user => user.Ident.Equals(tb_ident.Text));
                if (indexFound >= 0 )
                {
                    if (MessageBox.Show($"¿Está seguro de eliminar el usuario del empleado {tb_ident.Text}?", "Borrar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        listUsers.RemoveAt(indexFound);
                        tb_fullname.Clear();
                        tb_phone.Clear();
                        tb_username.Clear();
                        cb_userType.Items.Clear();
                        tb_password.Clear();

                        UserRefresh();

                        lbl_message.Text = $"El empleado con identificación {tb_ident.Text} fue borrado del sistema.";
                    }
                    
                }
                else
                {
                    lbl_message.Text = $"El empleado con identificación {tb_ident.Text} no se encuentra.";
                }
            }
        }
    }
}
