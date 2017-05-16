using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping
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
            
             Form1 login = new Form1();

            //使用模式对话框方法显示FLogin
            login.ShowDialog();
            if(login.DialogResult==DialogResult.OK)
            {
                Application.Run(new Main());
            }
        }
    }
}