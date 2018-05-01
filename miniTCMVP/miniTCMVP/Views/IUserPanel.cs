using miniTCMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCMVP.Views
{
    public interface IUserPanel
    {
        event Action<object, EventArgs> VEvent_OnLoad;
        event Action<object, EventArgs> VEvent_OnDropDown;
        event Action<object, EventArgs> VEvent_OnTextChanged;
        event Action<object, EventArgs> VEvent_OnSelectedIndexChanged;
        event Action<object, EventArgs> VEvent_OnMouseDoubleClick;
        event Action<object, EventArgs> VEvent_OnNewFolder;
        event Action<object, EventArgs> VEvent_OnRemove;
        void ShowDialogBox();

        string Path { get; set; }
        string[] Drives { set; }
        string CurrentDrive { get; }
        int IDCurrentDrive { set; get; }
        string[] Folders { set; }
        string CurrentFolder { get; }
        int IDCurrentFolder { get; }
        string[] FoldersToPrint { get; set; }
        string FolderName { get; set; }
    }
}
