using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using WindowsFormsApp2;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var userManager = new UserManager();
            var loginForm = new LoginForm(userManager);

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                var mainForm = new Form1(loginForm.AuthenticatedUser);
                Application.Run(mainForm);
            }
        }
    }
}
