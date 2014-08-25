using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TimeAssistant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] list)
        {
            bool isRunning;
            var m = new System.Threading.Mutex(true, "TimeAssistant", out isRunning);
            if (!isRunning)
            {
                MessageBox.Show("Another instance is already running.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
