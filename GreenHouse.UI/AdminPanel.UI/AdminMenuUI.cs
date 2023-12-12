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
    public partial class AdminMenuUI : Form
    {
        AdminMenuBLL _menuBLL = new AdminMenuBLL();
        AdminElemanBLL _elemanBLL = new AdminElemanBLL();
        public AdminMenuUI()
        {
            InitializeComponent();
        }

        private void AdminMenuUI_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            MenuleriListele();
        }

        private void MenuleriListele()
        {
            lstMenuler.Items.Clear();
            lstMenuler.Items.AddRange(_menuBLL.GetAll().Datas.ToArray());
        }

        private void lstMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMenuler.SelectedItem == null)
            {
                return;
            }
            txtMenuAdi.Text = (lstMenuler.SelectedItem as AdminMenuVM).MenuAdi;
        }

        private void btnMenuAra_Click(object sender, EventArgs e)
        {
            lstMenuler.Items.Clear();
            lstMenuler.Items.AddRange(_menuBLL.GetMenulerWithName(txtMenuAdi.Text).Datas.ToArray());
        }

        private void menuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMenuler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminMenuVM> generalReturnType = _menuBLL.Delete(lstMenuler.SelectedItem as AdminMenuVM);
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Menu Silindi.");
                Temizle();
                MenuleriListele();
            }
        }

        private void Temizle()
        {
            txtMenuAdi.Text =txtIconYolu.Text= txtElemanSirasi.Text = txtElemanLinkAdresi.Text = txtElemanAdi.Text = string.Empty;
            chSilinenElemanlariGoster.Checked = chElemanAktifMi.Checked = false;

        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            GeneralReturnType<AdminMenuVM> generalReturnType = _menuBLL.Add(new AdminMenuVM()
            {
                MenuAdi = txtMenuAdi.Text
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Menu Eklendi.Guncelleme için uygulamayı yeniden başlatınız.");
            DialogResult dg = MessageBox.Show(generalReturnType.Message + ": Menu Eklendi.Guncelleme için uygulamayı yeniden başlatmayı onaylıyor musunuz?.", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Restart();
            }
            Temizle();
            MenuleriListele();
        }

        private void btnMenuGuncelle_Click(object sender, EventArgs e)
        {
            if (lstMenuler.SelectedItem == null)
            {
                MessageBox.Show("Seçim yapınız.");
                return;
            }
            GeneralReturnType<AdminMenuVM> generalReturnType = _menuBLL.Update(new AdminMenuVM()
            {
                ID = (lstMenuler.SelectedItem as AdminMenuVM).ID,
                MenuAdi = txtMenuAdi.Text
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Menu Guncellendi");
            MenuleriListele();
            Temizle();
        }

        private void BtnFiltreleriTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            MenuleriListele();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
            if (tabControl1.SelectedTab == tpMenu)
            {
                MenuleriListele();
            }
            if (tabControl1.SelectedTab == tpEleman)
            {
                ElemanlariListele();
            }


        }

        private void chSilinenElemanlariGoster_CheckedChanged(object sender, EventArgs e)
        {
            ElemanlariListele();
        }

        private void ElemanlariListele()
        {
            lstElemanlar.Items.Clear();
            if (chSilinenElemanlariGoster.Checked)
            {
                lstElemanlar.Items.AddRange(_elemanBLL.GetAll().Datas.ToArray());
                return;
            }
            lstElemanlar.Items.AddRange(_elemanBLL.GetAllAktif().Datas.ToArray());
        }

        private void btnElemanAra_Click(object sender, EventArgs e)
        {
            lstElemanlar.Items.Clear();
            lstElemanlar.Items.AddRange(_elemanBLL.GetElemanlarWithName(txtElemanAdi.Text).Datas.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
            ElemanlariListele();
        }

        private void lstElemanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminElemanVM secilenEleman = lstElemanlar.SelectedItem as AdminElemanVM;
            if (lstElemanlar.SelectedItem == null)
            {
                return;
            }
            txtElemanAdi.Text = secilenEleman.MenuElemanAdi;
            txtElemanLinkAdresi.Text = secilenEleman.MenuLinkAdresi;
            txtElemanSirasi.Text = secilenEleman.MenuElemanSirasi.ToString();
            chElemanAktifMi.Checked = (bool)secilenEleman.AktifMi;
            txtIconYolu.Text = secilenEleman.MenuIconYolu;
        }

        private void btnElemanEkle_Click(object sender, EventArgs e)
        {
            GeneralReturnType<AdminElemanVM> generalReturnType = _elemanBLL.Add(new AdminElemanVM()
            {
                MenuElemanAdi = txtElemanAdi.Text,
                MenuElemanSirasi = int.Parse(txtElemanSirasi.Text),
                MenuLinkAdresi = txtElemanLinkAdresi.Text,
                AktifMi = chElemanAktifMi.Checked,
                MenuIconYolu = txtIconYolu.Text
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Eleman eklendi.");
            Temizle();
            ElemanlariListele();
        }

        private void btnElemanGuncelle_Click(object sender, EventArgs e)
        {
            if (lstElemanlar.SelectedItem == null)
            {
                MessageBox.Show("Secim yapınız.");
                return;
            }
            GeneralReturnType<AdminElemanVM> generalReturnType = _elemanBLL.Update(new AdminElemanVM()
            {
                ID = (lstElemanlar.SelectedItem as AdminElemanVM).ID,
                MenuElemanAdi = txtElemanAdi.Text,
                MenuElemanSirasi = int.Parse(txtElemanSirasi.Text),
                MenuLinkAdresi = txtElemanLinkAdresi.Text,
                AktifMi = chElemanAktifMi.Checked,
                MenuIconYolu = txtIconYolu.Text
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Eleman guncellendi.");
            Temizle();
            ElemanlariListele();
        }

        private void elemanSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstElemanlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminElemanVM> generalReturnType = _elemanBLL.Delete(lstElemanlar.SelectedItem as AdminElemanVM);
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": eleman Silindi.");
                Temizle();
                ElemanlariListele();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
