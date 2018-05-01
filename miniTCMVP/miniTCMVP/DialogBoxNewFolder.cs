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
    public partial class DialogBoxNewFolder : Form
    {
        public DialogBoxNewFolder()
        {
            InitializeComponent();
        }
        public string text;

        private void buttonDone_Click(object sender, EventArgs e)
        {
            text = this.textBox.Text;
            this.buttonDone.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            text = "";
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
