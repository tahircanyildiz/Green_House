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
    public partial class AdminUygulamaUI : Form
    {
        AdminUygulamaBLL _uygulamaBLL = new AdminUygulamaBLL();
        public AdminUygulamaUI()
        {
            InitializeComponent();
        }

        private void AdminUygulamaUI_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Listele();

        }

        private void Listele()
        {
            lstUygulamaAyarlari.Items.Clear();
            if (chSilinenUygulamaAyarlariGoster.Checked)
            {
                lstUygulamaAyarlari.Items.AddRange(_uygulamaBLL.GetAll().Datas.ToArray());
                return;
            }
            lstUygulamaAyarlari.Items.AddRange(_uygulamaBLL.GetAllAktif().Datas.ToArray());

        }

        private void chSilinenUygulamaAyarlariGoster_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnUygulamaAyariAra_Click(object sender, EventArgs e)
        {
            lstUygulamaAyarlari.Items.Clear();
            lstUygulamaAyarlari.Items.AddRange(_uygulamaBLL.GetYetkilerWithName(txtUygulamaAyariAdi.Text).Datas.ToArray());
        }

        private void BtnFiltreleriTemizle_Click(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void Temizle()
        {
            txtUygulamaAyariAdi.Text = txtLogoResimYolu.Text = string.Empty;
            chUygulamaAyariAktifMi.Checked = chKullanimKosullariGosterilsinMi.Checked = false;
        }

        private void btnUygulamaAyariEkle_Click(object sender, EventArgs e)
        {
            GeneralReturnType<AdminUygulamaVM> generalReturnType = _uygulamaBLL.Add(new AdminUygulamaVM()
            {
                Adi = txtUygulamaAyariAdi.Text,
                AktifMi = chUygulamaAyariAktifMi.Checked,
                KullanimKosullariniGostermeDurumu = chSilinenUygulamaAyarlariGoster.Checked,
                LogoResimYolu = txtLogoResimYolu.Text
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Uygulama Ayarı eklendi.");
            Listele();
            Temizle();
        }

        private void btnUygulamaAyariGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUygulamaAyarlari.SelectedItem == null)
            {
                MessageBox.Show("Seçim Yapınız.");
                return;
            }
            GeneralReturnType<AdminUygulamaVM> generalReturnType = _uygulamaBLL.Update(new AdminUygulamaVM()
            {
                ID = (lstUygulamaAyarlari.SelectedItem as AdminUygulamaVM).ID,
                Adi = txtUygulamaAyariAdi.Text,
                AktifMi = chUygulamaAyariAktifMi.Checked,
                KullanimKosullariniGostermeDurumu = chSilinenUygulamaAyarlariGoster.Checked,
                LogoResimYolu = txtLogoResimYolu.Text
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Uygulama Ayarı guncellendi.");
            Listele();
            Temizle();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lstUygulamaAyarlari.SelectedItem == null)
            {
                MessageBox.Show("Seçim Yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminUygulamaVM> generalReturnType = _uygulamaBLL.Delete(lstUygulamaAyarlari.SelectedItem as AdminUygulamaVM);

                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Uygulama Ayarı silindi.");
                Listele();
                Temizle();
            }
        }

        private void lstUygulamaAyarlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminUygulamaVM secilen = lstUygulamaAyarlari.SelectedItem as AdminUygulamaVM;
            if (secilen == null)
            {
                MessageBox.Show("Secim Yapınız");
                return;
            }
            txtLogoResimYolu.Text = secilen.LogoResimYolu;
            txtUygulamaAyariAdi.Text = secilen.Adi;
            chKullanimKosullariGosterilsinMi.Checked = (bool)secilen.KullanimKosullariniGostermeDurumu;
            chUygulamaAyariAktifMi.Checked = (bool)secilen.AktifMi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
