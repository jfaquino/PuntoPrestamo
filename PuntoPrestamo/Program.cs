using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoPrestamo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login.Login frmLogin = new Login.Login();
            frmLogin.FormClosed += new FormClosedEventHandler(FormClosed);
            frmLogin.Show();

            Application.Run();

        }
        
        /// <summary>
        /// Evita que el sistema quede abierto cuando se cierran todas las ventanas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
