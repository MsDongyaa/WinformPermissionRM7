using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM7.Login
{
    static class Program
    {
        private static MainFrame s_mainFrame;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool isLoginSuccessful = false;
            ShowLoginForm(ref isLoginSuccessful);
            if (isLoginSuccessful)
            {
                s_mainFrame = new MainFrame();
                Application.Run(s_mainFrame);
            }
        }

        private static void ShowLoginForm(ref bool isLoginSuccessful)
        {
            using (Login loginForm = new Login())
            {
                loginForm.ShowDialog();
                isLoginSuccessful = loginForm.IsLoginSuccessful;
            }
        }
    }
}
