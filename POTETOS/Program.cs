using POTETOS.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POTETOS
{
    internal static class Program
    {
        private static List<cls_users> listUsers = new List<cls_users>();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            frm_splash splash = new frm_splash();
            splash.Show(); 

           
            System.Threading.Thread.Sleep(5000); 

            
            splash.Close();


            frm_login main = new frm_login(listUsers);
            main.FormClosed += LoginClosed; 
            main.Show();
            Application.Run();
        }

        private static void LoginClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= LoginClosed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += LoginClosed;
            }
        }

    }
}
