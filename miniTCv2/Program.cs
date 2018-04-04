using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniTCv2
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

            Model model = new Model();
            View view = new View();
            MiniTCView viewLeft = new MiniTCView();
            MiniTCView ViewRight = new MiniTCView();
            Presenter p = new Presenter(model, viewLeft, ViewRight);

            Application.Run(view);
        }
    }
}
