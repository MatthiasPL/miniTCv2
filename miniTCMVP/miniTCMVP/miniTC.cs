using miniTCMVP.Models;
using miniTCMVP.Presenters;
using miniTCMVP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniTCMVP
{
    public partial class MiniTC : Form, IMiniTC
    {
        private UserPanelModel model;
        private UserPanelPresenter presenterLeft;
        private UserPanelPresenter presenterRight;

        private string focus;
        private string foldername;

        public string FolderName
        {
            get
            {
                return foldername;
            }
            set
            {
                foldername = value;
            }
        }

        public string NameFocus
        {
            get
            {
                return focus;
            }
        }

        public string LeftPath
        {
            get
            {
                return userPanelLeft.Path;
            }
        }

        public string RightPath
        {
            get
            {
                return userPanelRight.Path;
            }
        }

        public string LeftCurrentFolder
        {
            get
            {
                return userPanelLeft.CurrentFolder;
            }
        }

        public string RightCurrentFolder
        {
            get
            {
                return userPanelRight.CurrentFolder;
            }
        }

        public MiniTC()
        {
            InitializeComponent();

            model = new UserPanelModel();
            presenterLeft = new UserPanelPresenter(model, userPanelLeft);
            presenterRight = new UserPanelPresenter(model, userPanelRight);
        }

        public event Action<object, EventArgs> VEvent_OnCopy;
        public event Action<object, EventArgs> VEvent_OnMove;
        public event Action<object, EventArgs> VEvent_OnNewFolder;
        public event Action<object, EventArgs> VEvent_OnRemove;

        public void ShowDialogBoxNewFolder()
        {
            DialogBoxNewFolder testDialog = new DialogBoxNewFolder();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                // Console.WriteLine(testDialog.textBox.Text);
                FolderName = testDialog.textBox.Text;
            }
            else
            {
                FolderName = "";
            }
            testDialog.Dispose();
        }
        public void ShowDialogCopy()
        {
            DialogBoxCopy testDialog = new DialogBoxCopy();

            testDialog.tex
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            //if (testDialog.ShowDialog(this) == DialogResult.OK)
            //{
                // Read the contents of testDialog's TextBox.
                // Console.WriteLine(testDialog.textBox.Text);
                //FolderName = testDialog.textBox.Text;
            //}
            //else
            //{
                //FolderName = "";
            //}
            //testDialog.Dispose();
        }


        public void Refresh()
        {
            presenterLeft.Refresh();
            presenterRight.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VEvent_OnNewFolder != null)
            {
                VEvent_OnNewFolder(sender, e);
            }
        }

        private void userPanelLeft_Enter(object sender, EventArgs e)
        {
            focus = "left";
        }

        private void userPanelRight_Enter(object sender, EventArgs e)
        {
            focus = "right";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (VEvent_OnRemove != null)
            {
                VEvent_OnRemove(sender, e);
            }
        }
    }
}
