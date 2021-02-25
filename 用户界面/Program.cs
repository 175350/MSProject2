using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLLogen config = new SQLLogen();
            if (config.ShowDialog() == DialogResult.OK)
            {
               // UILogin log = new UILogin();
                //if (log.ShowDialog() == DialogResult.OK)
                //{
                    Application.Run(new UILogin());
               // }
            }
        }
    }
}
