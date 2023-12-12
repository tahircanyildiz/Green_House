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
    public partial class AdminMenuElemanUI : Form
    {
        AdminMenuElemanBLL _menuElemanBLL = new AdminMenuElemanBLL();
        AdminMenuBLL _menuBLL = new AdminMenuBLL();
        AdminElemanBLL _elemanBLL = new AdminElemanBLL();
        public AdminMenuElemanUI()
        {
            InitializeComponent();
        }

        private void AdminMenuElemanUI_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cmbElemanlarME.DataSource = _elemanBLL.GetAll().Datas;
            cmbElemanlarEM.DataSource = _elemanBLL.GetAll().Datas;

            cmbMenulerEM.DataSource = _menuBLL.GetAll().Datas;
            cmbMenulerME.DataSource = _menuBLL.GetAll().Datas;

            Temizle();
        }








        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();

        }

        private void Temizle()
        {
            cmbElemanlarME.SelectedItem = cmbMenulerME.SelectedItem = cmbElemanlarEM.SelectedItem = cmbMenulerEM.SelectedItem = null;
            lstMenuElemanları.Items.Clear();
            lstElemanMenuleri.Items.Clear();
        }

        private void cmbElemanlarEM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbElemanlarEM.SelectedItem == null)
            {
                return;
            }
            ElemanMenuleriListele();
        }

        private void ElemanMenuleriListele()
        {
            lstElemanMenuleri.Items.Clear();
            lstElemanMenuleri.Items.AddRange(_menuElemanBLL.GetMenuListWithElemanID(cmbElemanlarEM.SelectedItem as AdminElemanVM).Datas.ToArray());
        }

        private void cmbMenulerME_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenulerME.SelectedItem == null)
            {
                return;
            }
            MenuElemanlariListele();
        }

        private void MenuElemanlariListele()
        {
            lstMenuElemanları.Items.Clear();
            
            lstMenuElemanları.Items.AddRange(_menuElemanBLL.GetElemanListWithMenuID(cmbMenulerME.SelectedItem as AdminMenuVM).Datas.ToArray());
        }

        private void btnEkleMenuEleman_Click(object sender, EventArgs e)
        {
            if (cmbElemanlarME.SelectedItem == null || cmbMenulerME.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Seçimlerinizi Yapınız.");
                return;
            }
            AdminMenuVM secilenMenu = cmbMenulerME.SelectedItem as AdminMenuVM;
            GeneralReturnType<AdminMenuElemanVM> generalReturnType = _menuElemanBLL.Add(new AdminMenuElemanVM()
            {
                ElemanID = (cmbElemanlarME.SelectedItem as AdminElemanVM).ID,
                MenuID = secilenMenu.ID
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Eleman Menuye Eklendi..");
            Temizle();
            cmbMenulerME.SelectedItem = secilenMenu;
            MenuElemanlariListele();
        }
        private void menuElemanSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMenuElemanları.SelectedItem == null || cmbMenulerME.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                AdminMenuVM secilenMenu = (cmbMenulerME.SelectedItem as AdminMenuVM);
                GeneralReturnType<AdminMenuElemanVM> generalReturnType = _menuElemanBLL.Delete(new AdminMenuElemanVM()
                {
                    ElemanID = (lstMenuElemanları.SelectedItem as AdminElemanVM).ID,
                    MenuID = secilenMenu.ID
                });
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Eleman Menuden Silindi.");
                Temizle();
                cmbMenulerME.SelectedItem = secilenMenu;
                MenuElemanlariListele();
            }
        }

        private void btnEkleElemanMenu_Click(object sender, EventArgs e)
        {
            if (cmbElemanlarEM.SelectedItem == null || cmbMenulerEM.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Seçimlerinizi Yapınız.");
                return;
            }
            AdminElemanVM secilenEleman = cmbElemanlarEM.SelectedItem as AdminElemanVM;
            GeneralReturnType<AdminMenuElemanVM> generalReturnType = _menuElemanBLL.Add(new AdminMenuElemanVM()
            {
                ElemanID = secilenEleman.ID,
                MenuID = (cmbMenulerEM.SelectedItem as AdminMenuVM).ID
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Eleman Menuye Eklendi..");
            Temizle();
            cmbElemanlarEM.SelectedItem = secilenEleman;
            ElemanMenuleriListele();
        }

        private void elemanMenuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstElemanMenuleri.SelectedItem == null || cmbElemanlarEM.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                AdminElemanVM secilenEleman = cmbElemanlarEM.SelectedItem as AdminElemanVM;
                GeneralReturnType<AdminMenuElemanVM> generalReturnType = _menuElemanBLL.Delete(new AdminMenuElemanVM()
                {
                    ElemanID = secilenEleman.ID,
                    MenuID = (lstElemanMenuleri.SelectedItem as AdminMenuVM).ID
                });
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Menu Elemandan Silindi.");
                Temizle();
                cmbElemanlarEM.SelectedItem = secilenEleman;
                ElemanMenuleriListele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
