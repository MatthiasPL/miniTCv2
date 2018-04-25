using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniTCMVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //https://stackoverflow.com/questions/10555794/communication-between-mvp-triads
            //https://stackoverflow.com/questions/9761546/mvp-communication-between-presenters
            //https://stackoverflow.com/questions/13151102/user-controls-in-winform-application-with-mvp-pattern
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MiniTC());
        }
    }
}
