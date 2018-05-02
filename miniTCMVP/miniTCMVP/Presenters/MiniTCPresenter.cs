using miniTCMVP.Models;
using miniTCMVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCMVP.Presenters
{
    public class MiniTCPresenter
    {
        IMiniTC view;
        MiniTCModel model;
        public MiniTCPresenter(MiniTCModel model, IMiniTC view)
        {
            this.model = model;
            this.view = view;

            view.VEvent_OnCopy += View_VEventOnCopy;
            view.VEvent_OnMove += View_VEventOnMove;
            view.VEvent_OnNewFolder += View_VEventOnNewFolder;
            view.VEvent_OnRemove += View_VEventOnRemove;
        }

        private void View_VEventOnCopy(object arg1, EventArgs arg2)
        {

        }
        private void View_VEventOnMove(object arg1, EventArgs arg2)
        {

        }
        private void View_VEventOnNewFolder(object arg1, EventArgs arg2)
        {
            view.ShowDialogBoxNewFolder();
            if (view.NameFocus == "left")
            {
                model.CreateFolder(view.LeftPath, view.FolderName);
            }
            else if (view.NameFocus == "right")
            {
                model.CreateFolder(view.RightPath, view.FolderName);
            }
            view.Refresh();
        }
        private void View_VEventOnRemove(object arg1, EventArgs arg2)
        {
            if (view.NameFocus == "left")
            {
                model.RemoveFolder(view.LeftCurrentFolder);
            }
            else if (view.NameFocus == "right")
            {
                model.RemoveFolder(view.RightCurrentFolder);
            }
            view.Refresh();
        }
    }
}
