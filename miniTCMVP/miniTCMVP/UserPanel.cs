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

namespace miniTCMVP
{
    public partial class UserPanel : UserControl, IUserPanel
    {
        public UserPanel()
        {
            InitializeComponent();
        }

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
                throw new NotImplementedException(); 
                //Keeper?
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

        public event Action<object, EventArgs> VEvent_OnDoubleClick;
        public event Action<object, EventArgs> VEvent_OnDropDown;
        public event Action<object, EventArgs> VEvent_OnLoad;
        public event Action<object, EventArgs> VEvent_OnTextChanged;
    }
}
