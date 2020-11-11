using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{//tyomashiOurSource
    static class Program
    {
        /// <summary>/// Главная точка входа для приложения./// </summary>
        [STAThread]
        static void Main()
        {
          //tyomashi
            int dooble = 0;
            foreach (Process pr in Process.GetProcesses())
                if (pr.ProcessName == "Labs") dooble++;
            if (dooble > 1) Process.GetCurrentProcess().Kill();
          //tyomashi

          //app
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
          //app
        }
    }
}
