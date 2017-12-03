using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace SGM4711_Eva
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

            Process[] tProcess = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            //Console.WriteLine(Process.GetCurrentProcess().ProcessName);
            if (tProcess.Length > 1)
                Application.Exit();
            else
                Application.Run(new MainForm());
        }
    }
}
