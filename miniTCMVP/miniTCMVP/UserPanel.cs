using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using miniTCMVP.Views;
using miniTCMVP.Models;

namespace miniTCMVP
{
    public partial class UserPanel : UserControl, IUserPanel
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        #region interface
        public string CurrentDrive
        {
            get
            {
                return comboBoxDrives.SelectedItem.ToString();
            }
        }

        public string CurrentFolder
        {
            get
            {
                if (listBoxFolders.SelectedItem != null)
                    return listBoxFolders.SelectedItem.ToString();
                else
                    return "";
            }
        }

        public string[] Drives
        {
            set
            {
                 if (value != null)
                 {
                     comboBoxDrives.Items.Clear();
                     comboBoxDrives.Items.AddRange(value);
                 }
             }
        }

        public string[] Folders
        {
            set
            {
                if (value != null)
                {
                    listBoxFolders.Items.Clear();
                    listBoxFolders.Items.AddRange(value);
                }
            }
        }

        public int IDCurrentDrive
        {
            set
            {
                comboBoxDrives.SelectedIndex = value;
            }
            get
            {
                return comboBoxDrives.SelectedIndex;
            }
        }

        public string Path
        {
            get
            {
                return textBoxPath.Text;
            }

            set
            {
                textBoxPath.Text = value;
            }
        }

        public int IDCurrentFolder
        {
            get
            {
                return listBoxFolders.SelectedIndex;
            }
        }

        private string[] folderstoprint;
        public string[] FoldersToPrint
        {
            get
            {
                return folderstoprint;
            }

            set
            {
                folderstoprint = value;
            }
        }
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

        public event Action<object, EventArgs> VEvent_OnDropDown;
        public event Action<object, EventArgs> VEvent_OnLoad;
        public event Action<object, EventArgs> VEvent_OnTextChanged;
        public event Action<object, EventArgs> VEvent_OnSelectedIndexChanged;
        public event Action<object, EventArgs> VEvent_OnMouseDoubleClick;
        public event Action<object, EventArgs> VEvent_OnNewFolder;
        public event Action<object, EventArgs> VEvent_OnRemove;
        #endregion

        public void ShowDialogBox()
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
                FolderName = "New folder";
            }
            testDialog.Dispose();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            if (VEvent_OnLoad != null)
            {
                VEvent_OnLoad(sender, e);
            }
        }

        private void comboBoxDrives_DropDown(object sender, EventArgs e)
        {
            if (VEvent_OnDropDown != null)
            {
                VEvent_OnDropDown(sender, e);
            }
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            if (VEvent_OnTextChanged != null)
            {
                VEvent_OnTextChanged(sender, e);
            }
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VEvent_OnSelectedIndexChanged != null)
            {
                VEvent_OnSelectedIndexChanged(sender, e);
            }
        }

        private void listBoxFolders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (VEvent_OnMouseDoubleClick != null)
            {
                VEvent_OnMouseDoubleClick(sender, e);
            }
        }

        private void buttonNewFolder_Click(object sender, EventArgs e)
        {
            if (VEvent_OnNewFolder != null)
            {
                VEvent_OnNewFolder(sender, e);
            }
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
