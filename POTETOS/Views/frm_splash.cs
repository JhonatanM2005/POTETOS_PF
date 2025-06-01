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
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_splash_Load(object sender, EventArgs e)
        {
           
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;

                // Simulación de carga
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    System.Threading.Thread.Sleep(20);  
                }
            

        }
    }
}
