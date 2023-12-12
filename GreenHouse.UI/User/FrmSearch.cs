
using GreenHouse.BLL;
using GreenHouse.BLL.AdminsBLL;
using GreenHouse.BLL.UsersBLL;
using GreenHouse.UI.User;
using GreenHouse.VM.VM;
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
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(txtProductName.Text != string.Empty)
            {
                lstProduct.DataSource = new UserUrunBLL().AdIleGetirBLL(txtProductName.Text);
                new AramaGecmisiBLL().EkleAramaGecmisiBLL(new AramaGecmisiVM()
                {
                    ID = Guid.NewGuid(),
                    AramaMetni = txtProductName.Text,
                    KullaniciID = Guid.Parse("96839c73-1738-4593-be90-627c12387c00"),
                    AramaZamani = DateTime.Now,
                    AktifMi = true
                });
            }
            else
            {
                MessageBox.Show("Amogus");
            }
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = new KategoriBLL().GetirKategoriBLL();
            lstProduct.DataSource = new UserUrunBLL().GetirBLL();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            FrmUser user = new FrmUser();

            user.Show();
        }

        private void BtnSideMenu_Click(object sender, EventArgs e)
        {
            FrmSideMenu side = new FrmSideMenu();
            side.Show();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu main = new FrmMainMenu();
            main.Show();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbCategory.SelectedItem != null)
            {
                
                lstProduct.DataSource = new UserUrunBLL().KategoriIleGetirBLL(cmbCategory.SelectedItem as KategoriVM);
            }
            else
            {
                MessageBox.Show("Amogus");
            }
        }


        private void lstProduct_DoubleClick(object sender, EventArgs e)
        {
            ProductContent productContent = new ProductContent(lstProduct.SelectedItem as UrunVM);
            productContent.MdiParent = this.MdiParent;
            productContent.Show();
        }
    }
}
