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
        private string copySource;
        private string copyOutput;
        private string copyFileName;

        #region interface
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

        public string CopyOutputName
        {
            get
            {
                return copyFileName;
            }

            set
            {
                copyFileName = value;
            }
        }

        public string CopySource
        {
            get
            {
                return copySource;
            }

            set
            {
                copySource = value;
            }
        }

        public string CopyOutput
        {
            get
            {
                return copyOutput;
            }

            set
            {
                copyOutput = value;
            }
        }
        #endregion

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

            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
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
            testDialog.textBoxInput.Text = CopySource;
            testDialog.textBoxOutput.Text = CopyOutput;
            testDialog.textBoxOutputName.Text = CopyOutputName;

            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                CopyOutputName = testDialog.textBoxOutputName.Text;
            }
            else
            {
                CopyOutputName = "";
            }

            //testDialog.textBoxInput.Width
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
            testDialog.Dispose();
        }


        override public void Refresh()
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

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (VEvent_OnCopy != null)
            {
                VEvent_OnCopy(sender, e);
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (VEvent_OnMove != null)
            {
                VEvent_OnMove(sender, e);
            }
        }
    }
}
