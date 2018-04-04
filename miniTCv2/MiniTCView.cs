using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace miniTCv2
{
    public partial class MiniTCView : IView
    {
        public static event Action<MiniTCView> LoadDrives;
        public static event Action<MiniTCView> ChangePath;
        public MiniTCView()
        {
            InitializeComponent();
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

        public string CurrentDrive
        {
            get
            {
                try
                {
                    return comboBoxDrives.SelectedItem.ToString();
                }
                catch(Exception ex)
                {
                    return "";
                }
                
            }
        }

        public string[] Drives
        {
            get
            {
                return comboBoxDrives.Items.Cast<string>().ToArray();
            }
            set
            {
                if (value != null)
                {
                    comboBoxDrives.Items.Clear();
                    comboBoxDrives.Items.AddRange(value);
                }
            }
        }

        public string[] Content
        {
            get
            {
                return listBoxContainer.Items.Cast<string>().ToArray();
            }
            set
            {
                if (value != null)
                {
                    listBoxContainer.Items.Clear();
                    listBoxContainer.Items.AddRange(value);
                }
            }
        }

        public override void addMethod(Action<MiniTCView> akcja)
        {
            LoadDrives += akcja;
        }


        private void comboBoxDrives_DropDown(object sender, EventArgs e)
        {
            if (LoadDrives != null)
                LoadDrives(this);
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChangePath != null)
                ChangePath(this);
        }
    }
}
