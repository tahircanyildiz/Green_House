using GreenHouse.UI.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.UserUI
{
    public partial class FrmSideMenu : Form
    {
        public FrmSideMenu()
        {
            InitializeComponent();
        }

        private void BtnPremiumUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.MdiParent = this.MdiParent;
            frmAbout.Show();
        }

        private void BtnContactUs_Click(object sender, EventArgs e)
        {
            FrmContactUs frmContactUs = new FrmContactUs();
            frmContactUs.MdiParent = this.MdiParent;
            frmContactUs.Show();
        }

        private void BtnUseCondition_Click(object sender, EventArgs e)
        {

        }

        private void BtnNotifications_Click(object sender, EventArgs e)
        {

        }

        private void BtnInstagram_Click(object sender, EventArgs e)
        {

        }

        private void BtnTwitter_Click(object sender, EventArgs e)
        {

        }

        private void BtnFacebook_Click(object sender, EventArgs e)
        {

        }

        private void BtnShareApp_Click(object sender, EventArgs e)
        {

        }

        private void BtnGivePointToApp_Click(object sender, EventArgs e)
        {

        }
    }
}
