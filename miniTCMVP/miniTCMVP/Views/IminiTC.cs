using miniTCMVP.Models;
using miniTCMVP.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCMVP.Views
{
    public interface IMiniTC
    {
        event Action<object, EventArgs> VEvent_OnNewFolder;
        event Action<object, EventArgs> VEvent_OnRemove;
        event Action<object, EventArgs> VEvent_OnCopy;
        event Action<object, EventArgs> VEvent_OnMove;

        void ShowDialogBoxNewFolder();
        void ShowDialogCopy();
        void Refresh();

        string FolderName { get; set; }
        string NameFocus { get; }
        string LeftPath { get; }
        string RightPath { get; }
        string LeftCurrentFolder { get; }
        string RightCurrentFolder { get; }
        string CopySource { get; set; }
        string CopyOutput { get; set; }
        string CopyOutputName { get; set; }
    }
}
