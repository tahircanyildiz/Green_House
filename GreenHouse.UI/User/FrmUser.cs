using GreenHouse.BLL.UsersBLL;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.UI.User;
using GreenHouse.VM.User;
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
    public partial class FrmUser : Form
    {
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        public FrmUser()
        {
            InitializeComponent();
        }

        private void BtnPremiumUser_Click(object sender, EventArgs e)
        {
            FrmPremium frmPremium = new FrmPremium();
            frmPremium.MdiParent = this.MdiParent;
            frmPremium.Show();
        }

        private void BtnChangeEmail_Click(object sender, EventArgs e)
        {
            UserEmailReset userEmailReset = new UserEmailReset();
            userEmailReset.MdiParent = this.MdiParent;
            userEmailReset.Show();

        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            UserPasswordReset userPasswordReset = new UserPasswordReset();
            userPasswordReset.MdiParent = this.MdiParent;
            userPasswordReset.Show();
        }

        private void BtnLinkWithSocialMedia_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateProfile_Click(object sender, EventArgs e)
        {

        }

        private void BtnFavorites_Click(object sender, EventArgs e)
        {
            FrmFavorites frmFavorites = new FrmFavorites();
            frmFavorites.MdiParent = this.MdiParent;
            frmFavorites.Show();
        }

        private void BtnBlackList_Click(object sender, EventArgs e)
        {
            BlackList blackList = new BlackList();
            blackList.MdiParent = this.MdiParent;
            blackList.Show();
        }

        private void BtnClearSearchHistory_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void BtnSideMenu_Click(object sender, EventArgs e)
        {

        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            lblUserAddedProduct.Text = new UrunOnayBLL().KullaniciUrunGetirBLL(gelenUser.Datas.ID).Count.ToString();
            lblSinceUser.Text = gelenUser.Datas.CreatedDate.ToString();
            lblUsername.Text = gelenUser.Datas.Name +" "+gelenUser.Datas.Surname;
        }
    }
}
