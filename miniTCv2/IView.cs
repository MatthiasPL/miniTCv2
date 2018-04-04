using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniTCv2
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<IView, UserControl>))]
    public abstract class IView : UserControl
    {
        event Action<MiniTCView> LoadDrives;
        event Action<MiniTCView> ChangePath;

        string Path { get; set; }
        string[] Drives { get; }
        string[] Content { get; set; }
        string CurrentDrive { get; }

        public abstract void addMethod(Action<MiniTCView> akcja);
    }
}
