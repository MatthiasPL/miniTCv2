using miniTCMVP.Models;
using miniTCMVP.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (view.NameFocus == "left")
            {
                view.CopySource = view.LeftCurrentFolder;
                view.CopyOutput = view.RightPath;
                view.CopyOutputName = model.FolderCutter(view.CopySource);
            }
            else
            {
                view.CopySource = view.RightCurrentFolder;
                view.CopyOutput = view.LeftPath;
                view.CopyOutputName = model.FolderCutter(view.CopySource);
            }

            if(view.CopySource!="" && view.CopyOutput != "")
            {
                view.ShowDialogCopy();

                if (Directory.Exists(view.CopySource))
                {
                    Thread t = new Thread(() => model.Copy(view.CopySource, view.CopyOutput));
                    t.Start();
                }
                else if (File.Exists(view.CopySource))
                {
                    Thread t = new Thread(() => model.Copy(view.CopySource, view.CopyOutput, view.CopyOutputName));
                    t.Start();
                }
            }
            view.Refresh();
        }
        private void View_VEventOnMove(object arg1, EventArgs arg2)
        {
            if (view.NameFocus == "left")
            {
                view.CopySource = view.LeftCurrentFolder;
                view.CopyOutput = view.RightPath;
            }
            else
            {
                view.CopySource = view.RightCurrentFolder;
                view.CopyOutput = view.LeftPath;
            }
            if(view.CopySource!="" && view.CopyOutput != "")
            {
                view.ShowDialogCopy();
                model.Move(view.CopySource, view.CopyOutput);
            }
            view.Refresh();
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
            DialogResult dialogResult = MessageBox.Show("Do you want to remove this file/folder?", "Remove", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (view.NameFocus == "left")
                {
                    if (Directory.Exists(view.LeftCurrentFolder))
                        model.RemoveFolder(view.LeftCurrentFolder);
                    else
                        model.RemoveFile(view.LeftCurrentFolder);
                }
                else if (view.NameFocus == "right")
                {
                    if (Directory.Exists(view.RightCurrentFolder))
                        model.RemoveFolder(view.RightCurrentFolder);
                    else
                        model.RemoveFile(view.RightCurrentFolder);
                }
                view.Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
