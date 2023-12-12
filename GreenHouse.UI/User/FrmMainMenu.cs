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
    public partial class FrmMainMenu : Form
    {
        private bool MDIFormAcikmi(string formAdi)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == formAdi)
                {
                    return true;
                }
            }
            return false;
        }
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void BtnSideMenu_Click(object sender, EventArgs e)
        {
            FrmSideMenu side = new FrmSideMenu();
            if (!MDIFormAcikmi(side.Name))
            {
                side.MdiParent = this.MdiParent;
                side.Show();
            }
            return;

        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            if (this == null)
            {
                FrmMainMenu main = new FrmMainMenu();
                if (!MDIFormAcikmi(main.Name))
                {
                    main.MdiParent = this.MdiParent;
                    main.Show();
                }
                return;
            }

        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            FrmUser user = new FrmUser();
            if (!MDIFormAcikmi(user.Name))
            {
                user.MdiParent = this.MdiParent;
                user.Show();
            }
            return;

        }


        private void BtnBarcodeRead_Click(object sender, EventArgs e)
        {
            FrmBarcode frmBarcode = new FrmBarcode();
            if (!MDIFormAcikmi(frmBarcode.Name))
            {
                frmBarcode.MdiParent = this.MdiParent;
                frmBarcode.Show();
            }
            return;

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            if (!MDIFormAcikmi(frmSearch.Name))
            {
                frmSearch.MdiParent = this.MdiParent;
                frmSearch.Show();
                frmSearch.BringToFront();
            }
            return;


        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            if (!MDIFormAcikmi(frmAddProduct.Name))
            {
                frmAddProduct.MdiParent = this.MdiParent;
                frmAddProduct.Location = new Point(this.Location.X + this.Width + 500, this.Location.Y + 100);
                frmAddProduct.Show();
            }
            return;


        }

        private void BtnSearchHistory_Click(object sender, EventArgs e)
        {
            FrmSearchHistory frmSearchHistory = new FrmSearchHistory();
            if (!MDIFormAcikmi(frmSearchHistory.Name))
            {
                frmSearchHistory.MdiParent = this.MdiParent;
                frmSearchHistory.Show();
                frmSearchHistory.BringToFront();
            }
            return;
        }
    }
}
