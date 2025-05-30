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
    public partial class frm_index : Form
    {
        private List<cls_users> Users;

        private string userRole;
        public frm_index(List<cls_users> users, string userRole)
        {
            InitializeComponent();
            Users = users;
            this.userRole = userRole;
        }

        private void b_home_Click(object sender, EventArgs e)
        {
            pnl_positiononbtn.Height = b_home.Height;
            pnl_positiononbtn.Top = b_home.Top;
            pnl_home.Visible = true;
            pnl_menu.Visible = false;
            pnl_tables.Visible = false;
            pnl_deliverys.Visible = false;
            pnl_about.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnl_positiononbtn.Height = b_menu.Height;
            pnl_positiononbtn.Top = b_menu.Top;
            pnl_home.Visible = false;
            pnl_menu.Visible = true;
            pnl_tables.Visible = false;
            pnl_deliverys.Visible = false;
            pnl_about.Visible = false;
        }

        private void frm_index_Load(object sender, EventArgs e)
        {
            lbl_user.Text = $"{userRole}";
        }

        private void b_tables_Click(object sender, EventArgs e)
        {
            pnl_positiononbtn.Height = b_tables.Height;
            pnl_positiononbtn.Top = b_tables.Top;
            pnl_home.Visible = false;
            pnl_menu.Visible = false;
            pnl_tables.Visible = true;
            pnl_deliverys.Visible = false;
            pnl_about.Visible = false;
        }

        private void b_deliverys_Click(object sender, EventArgs e)
        {
            pnl_positiononbtn.Height = b_deliverys.Height;
            pnl_positiononbtn.Top = b_deliverys.Top;
            pnl_home.Visible = false;
            pnl_menu.Visible = false;
            pnl_tables.Visible = false;
            pnl_deliverys.Visible = true;
            pnl_about.Visible = false;
        }

        private void b_about_Click(object sender, EventArgs e)
        {
            pnl_positiononbtn.Height = b_about.Height;
            pnl_positiononbtn.Top = b_about.Top;
            pnl_home.Visible = false;
            pnl_menu.Visible = false;
            pnl_tables.Visible = false;
            pnl_deliverys.Visible = false;
            pnl_about.Visible = true;
        }

        private void pb_profile_Click(object sender, EventArgs e)
        {

        }

        private void pnl_leftside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            frm_login loginForm = new frm_login(Users);
            loginForm.Show();
            this.Close();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void pnl_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_table1_Click(object sender, EventArgs e)
        {
            b_table1.BackColor = Color.FromArgb(100, 149, 237);
        }

        private void b_table2_Click(object sender, EventArgs e)
        {
            b_table1.BackColor = Color.FromArgb(100, 149, 237);
        }

        private void b_table3_Click(object sender, EventArgs e)
        {
            b_table1.BackColor = Color.FromArgb(100, 149, 237);
        }

        private void b_table4_Click(object sender, EventArgs e)
        {
            b_table1.BackColor = Color.FromArgb(100, 149, 237);
        }
    }
}
