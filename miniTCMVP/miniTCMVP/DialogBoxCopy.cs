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
    public partial class DialogBoxCopy : Form
    {
        public DialogBoxCopy()
        {
            InitializeComponent();
        }

        public string outputName;

        private void button1_Click(object sender, EventArgs e)
        {
            outputName = textBoxOutputName.Text;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputName = "";
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
