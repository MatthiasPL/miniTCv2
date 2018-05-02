using miniTCMVP.Models;
using miniTCMVP.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCMVP.Presenters
{
    public class UserPanelPresenter
    {
        IUserPanel view;
        UserPanelModel model;
        
        public UserPanelPresenter(UserPanelModel model, IUserPanel view)
        {
            this.model = model;
            this.view = view;

            view.VEvent_OnLoad += View_VEventOnLoad;
            view.VEvent_OnDropDown += View_VEventOnDropdown;
            view.VEvent_OnTextChanged += View_VEventOnTextChanged;
            view.VEvent_OnSelectedIndexChanged += View_VEventOnSelectedIndexChanged;
            view.VEvent_OnMouseDoubleClick += View_VEventOnMouseDoubleClick;
            view.VEvent_OnNewFolder += View_VEventOnNewFolder;
            view.VEvent_OnRemove += View_VEventOnRemove;
        }

        public string GetPath()
        {
            return view.Path;
        }

        public string GetCurrentFolder()
        {
            return view.CurrentFolder;
        }
        public void Refresh()
        {
            view.Folders = model.LoadFolders(view.Path);
        }

        private void View_VEventOnLoad(object arg1, EventArgs arg2)
        {
            view.Drives=model.LoadDrives();
            view.IDCurrentDrive = 0;
            view.Folders = model.LoadFolders(view.CurrentDrive);
            view.Path = view.CurrentDrive;
        }
        private void View_VEventOnDropdown(object arg1, EventArgs arg2)
        {
            view.Drives = model.LoadDrives();
        }
        private void View_VEventOnTextChanged(object arg1, EventArgs arg2)
        {
            if (Directory.Exists(view.Path))
            {
                view.Folders = model.LoadFolders(view.Path);
            }
        }
        private void View_VEventOnSelectedIndexChanged(object arg1, EventArgs arg2)
        {
            view.Path = view.CurrentDrive;
            view.Folders = model.LoadFolders(view.CurrentDrive);
        }
        private void View_VEventOnMouseDoubleClick(object arg1, EventArgs arg2)
        {
            if (view.CurrentFolder == "..")
            {
                view.Path = model.FolderUp(view.Path);
                if (view.Path.Length == 2)
                    view.Path = view.CurrentDrive;
                view.Folders = model.LoadFolders(view.Path);
            }
            else
            {
                if (Directory.Exists(view.CurrentFolder))
                {
                    view.Path = view.CurrentFolder;
                    view.Folders = model.LoadFolders(view.Path);
                }
                else
                {
                    if(view.CurrentFolder!="")
                        System.Diagnostics.Process.Start(view.CurrentFolder);
                }
            }
        }
        private void View_VEventOnNewFolder(object obj1, EventArgs arg2)
        {
            view.ShowDialogBox();
            model.CreateFolder(view.Path, view.FolderName);
            view.Folders = model.LoadFolders(view.Path);
        }
        private void View_VEventOnRemove(object obj1, EventArgs arg2)
        {
            model.RemoveFolder(view.CurrentFolder);
            view.Folders = model.LoadFolders(view.Path);
        }
    }
}
