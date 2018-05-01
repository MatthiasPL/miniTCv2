using miniTCMVP.Models;
using miniTCMVP.Presenters;
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
    public partial class MiniTC : Form
    { 
        public MiniTC()
        {
            InitializeComponent();

            UserPanelModel model = new UserPanelModel();
            UserPanelPresenter presenterLeft = new UserPanelPresenter(model, userPanelRight);
            UserPanelPresenter presenterRight = new UserPanelPresenter(model, userPanelLeft);
        }
    }
}
