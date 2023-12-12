using GreenHouse.BLL.AdminsBLL;
using GreenHouse.Core.Common;
using GreenHouse.VM.AdminVMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.AdminPanel.UI
{
    public partial class AdminSayfaMenuUI : Form
    {
        AdminSayfaBLL _sayfaBBL = new AdminSayfaBLL();
        AdminMenuBLL _menuBBL = new AdminMenuBLL();
        AdminSayfaMenuBLL _sayfaMenuBLL = new AdminSayfaMenuBLL();
        public AdminSayfaMenuUI()
        {
            InitializeComponent();
        }

        private void AdminSayfaMenuYetkiUI_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cmbSayfalarSM.DataSource = _sayfaBBL.GetAll().Datas;
            cmbMenulerSM.DataSource = _menuBBL.GetAll().Datas;

            cmbMenulerMS.DataSource = _menuBBL.GetAll().Datas;
            cmbSayfalarMS.DataSource = _menuBBL.GetAll().Datas;
            Temizle();
        }

        private void Temizle()
        {
            cmbSayfalarSM.SelectedItem = cmbMenulerSM.SelectedItem = cmbMenulerMS.SelectedItem = cmbSayfalarMS.SelectedItem = null;
            lstMenuSayfalari.Items.Clear();
            lstSayfaMenuleri.Items.Clear();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
        }
        private void cmbSayfalarSM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSayfalarSM.SelectedItem == null)
            {
                return;
            }
            SayfaMenuleriListele();
        }
        private void cmbMenulerMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenulerMS.SelectedItem == null)
            {
                return;
            }
            MenuSayfalariListele();
        }


        private void MenuSayfalariListele()
        {
            lstMenuSayfalari.Items.Clear();
            lstMenuSayfalari.Items.AddRange(_sayfaMenuBLL.GetSayfalarListWithMenuID(cmbMenulerMS.SelectedItem as AdminMenuVM).Datas.ToArray());
        }

        private void SayfaMenuleriListele()
        {
            lstSayfaMenuleri.Items.Clear();
            lstSayfaMenuleri.Items.AddRange(_sayfaMenuBLL.GetMenulerListWithSayfaID(cmbSayfalarSM.SelectedItem as AdminSayfaVM).Datas.ToArray());
        }


        #region Ekle Sayfa-Menu
        private void btnEkleSayfaMenu_Click(object sender, EventArgs e)
        {
            if (cmbSayfalarSM.SelectedItem == null || cmbMenulerSM.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            AdminSayfaVM secilenSayfa = (cmbSayfalarSM.SelectedItem as AdminSayfaVM);
            GeneralReturnType<AdminSayfaMenuVM> generalReturnType = _sayfaMenuBLL.Add(new AdminSayfaMenuVM()
            {
                MenuID = (cmbMenulerSM.SelectedItem as AdminMenuVM).ID,
                SayfaID = secilenSayfa.ID
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Menu Sayfaya Eklendi..");
            Temizle();
            cmbSayfalarSM.SelectedItem = secilenSayfa;
            SayfaMenuleriListele();
        }
        #endregion

        #region Sil Sayfa-Menu
        private void sayfaMenuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbSayfalarSM.SelectedItem == null || lstSayfaMenuleri.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                AdminSayfaVM secilenSayfa = (cmbSayfalarSM.SelectedItem as AdminSayfaVM);
                GeneralReturnType<AdminSayfaMenuVM> generalReturnType = _sayfaMenuBLL.Delete(new AdminSayfaMenuVM()
                {
                    MenuID = (lstSayfaMenuleri.SelectedItem as AdminMenuVM).ID,
                    SayfaID = secilenSayfa.ID
                });
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Menu Sayfadan Silindi.");
                Temizle();
                cmbSayfalarSM.SelectedItem = secilenSayfa;
                SayfaMenuleriListele();
            }
        }
        #endregion

        #region Ekle Menu-Sayfa
        private void btnEkleMenuSayfa_Click(object sender, EventArgs e)
        {
            if (cmbSayfalarMS.SelectedItem == null || cmbMenulerMS.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            AdminMenuVM secilenMenu = (cmbMenulerMS.SelectedItem as AdminMenuVM);
            GeneralReturnType<AdminSayfaMenuVM> generalReturnType = _sayfaMenuBLL.Add(new AdminSayfaMenuVM()
            {
                MenuID = secilenMenu.ID,
                SayfaID = (cmbSayfalarSM.SelectedItem as AdminSayfaVM).ID
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Sayfa Menuye Eklendi..");
            Temizle();
            cmbMenulerMS.SelectedItem = secilenMenu;
            MenuSayfalariListele();
        }
        #endregion

        #region Sil Menu-Sayfa
        private void menuSayfaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbMenulerMS.SelectedItem == null || lstMenuSayfalari.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                AdminMenuVM secilenMenu = (lstSayfaMenuleri.SelectedItem as AdminMenuVM);
                GeneralReturnType<AdminSayfaMenuVM> generalReturnType = _sayfaMenuBLL.Delete(new AdminSayfaMenuVM()
                {
                    MenuID = secilenMenu.ID,
                    SayfaID = (cmbSayfalarSM.SelectedItem as AdminMenuVM).ID
                });
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Sayfa Menuden Silindi.");
                Temizle();
                cmbMenulerMS.SelectedItem = secilenMenu;
                MenuSayfalariListele();
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
