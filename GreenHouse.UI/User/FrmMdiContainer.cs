using GreenHouse.UI.User;
using GreenHouse.VM.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.UserUI
{
    public partial class FrmMdiContainer : Form
    {
        FrmMainMenu frmMainMenu;
        public FrmMdiContainer()
        {
            InitializeComponent();
        }
        GirisYapKullaniciVM _girisYapanKullanici;
        public FrmMdiContainer(GirisYapKullaniciVM girisYapanKullanici) : this()
        {
            _girisYapanKullanici = girisYapanKullanici;
        }


        private void FrmMdiContainer_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            frmMainMenu = new FrmMainMenu();
            frmMainMenu.MdiParent = this;
            frmMainMenu.Height = this.Height;
            frmMainMenu.Show();
            frmMainMenu.FormClosed += OnFormClosed;
        }

        public void OnFormClosed(object sender, EventArgs e)
        {
            
            frmMainMenu = null;
        }
        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmMainMenu == null)
            {
                frmMainMenu = new FrmMainMenu();
                frmMainMenu.MdiParent = this;
                frmMainMenu.Show();
            }
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();

        }
    }
}
