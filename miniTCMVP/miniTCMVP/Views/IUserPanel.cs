using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCMVP.Views
{
    interface IUserPanel
    {
        event Action<object, EventArgs> VEvent_OnLoad;
        event Action<object, EventArgs> VEvent_OnDropDown;
        event Action<object, EventArgs> VEvent_OnTextChanged;
        event Action<object, EventArgs> VEvent_OnDoubleClick;

        string Path { get; set; }
        string[] Drives { set; }
        string CurrentDrive { get; }
        int IDCurrentDrive { get; }
        string[] Folders { set; }
        string CurrentFolder { get; }
    }
}
