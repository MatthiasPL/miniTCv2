using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCv2
{
    class Presenter
    {
        public Presenter(Model model, IView viewLeft, IView viewRight)
        {
            viewLeft.LoadDrives += View_LoadDrives;
            viewRight.LoadDrives += View_LoadDrives;
            viewLeft.ChangePath += View_ChangePath;
            viewRight.ChangePath += View_ChangePath;
            //viewRight.addMethod(View_LoadDrives);
            //viewLeft.addMethod(View_ChangePath);
        }

        public void View_LoadDrives(MiniTCView view)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            List<string> dyski = new List<string> { };
            foreach (DriveInfo d in allDrives)
            {
                /*if (!d.IsReady)
                {
                    Console.Write("Dysk {0} nie jest gotowy.", d.Name);
                }
                else
                {*/
                dyski.Add(d.Name);
                //}
            }
            view.Drives = dyski.ToArray();
        }

        public void View_ChangePath(MiniTCView view)
        {
            view.Path=view.CurrentDrive;
        }


    }
}
