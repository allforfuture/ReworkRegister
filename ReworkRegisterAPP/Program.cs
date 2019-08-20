using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReworkRegisterAPP
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
            IsUpdateEnable isupdate = new IsUpdateEnable();
            if (isupdate.bFlag)
            {
                System.Diagnostics.Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutoUpdater_Simple.exe"));
                Application.Exit();
            }
            else
            { 
                Application.Run(new Main2());
            }
        }
    }
}
