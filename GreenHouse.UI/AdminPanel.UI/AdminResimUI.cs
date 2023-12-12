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
    public partial class AdminResimUI : Form
    {
        AdminUrunBLL _adminUrunBLL = new AdminUrunBLL();
        AdminResimBLL _adminResimBLL = new AdminResimBLL();
        public AdminResimUI()
        {
            InitializeComponent();
        }

        private void Resim_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cmbUrunler.DataSource = _adminUrunBLL.GetList().Datas;

            Temizle();
        }

        private void cmbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunFotograflariniListele();
        }

        private void UrunFotograflariniListele()
        {
            if (cmbUrunler.SelectedItem == null)
            {
                return;
            }
            lstUrunFotograflari.Items.Clear();
            lstUrunFotograflari.Items.AddRange(_adminResimBLL.GetResimlerWithUrunID(cmbUrunler.SelectedItem as AdminUrunVM).Datas.ToArray());
        }
        private void Temizle()
        {
            cmbUrunler.SelectedItem = null;
            txtResimYolu.Text = string.Empty;
            cbAktifMi.Checked =chOnYuzMu.Checked= false;
            lstUrunFotograflari.Items.Clear();
            
        }
        private void lstUrunFotograflari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunFotograflari.SelectedItem == null)
            {
                return;
            }
            AdminResimVM secilen = lstUrunFotograflari.SelectedItem as AdminResimVM;
            txtResimYolu.Text = secilen.ResimYolu;
            chOnYuzMu.Checked = (bool)secilen.ResimYuzu;
            cbAktifMi.Checked = (bool)secilen.AktifMi;
            
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbUrunler.SelectedItem == null)
            {
                MessageBox.Show("Urun Seciniz.");
                return;
            }
            AdminUrunVM secilenUrun = (cmbUrunler.SelectedItem as AdminUrunVM);
            GeneralReturnType<AdminResimVM> generalReturnType = _adminResimBLL.Add(new AdminResimVM()
            {
                ID = Guid.NewGuid(),
                UrunID = secilenUrun.ID,
                ResimYolu = txtResimYolu.Text,
                AktifMi = cbAktifMi.Checked,
                ResimYuzu = chOnYuzMu.Checked
            }) ;
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Urune Resim Eklendi.");
            Temizle();
            cmbUrunler.SelectedItem = secilenUrun;
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbUrunler.SelectedItem == null || lstUrunFotograflari.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi yapınız.");
                return;
            }
            AdminUrunVM secilenUrun = (cmbUrunler.SelectedItem as AdminUrunVM);
            GeneralReturnType<AdminResimVM> generalReturnType = _adminResimBLL.Update(new AdminResimVM()
            {
                ID = (lstUrunFotograflari.SelectedItem as AdminResimVM).ID,
                ResimYolu = txtResimYolu.Text,
                UrunID = secilenUrun.ID,
                ResimYuzu = chOnYuzMu.Checked,
                AktifMi=cbAktifMi.Checked
            });
            if (generalReturnType.StatusCode!=200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message+": Resim guncellendi.");
            Temizle();
            cmbUrunler.SelectedItem = secilenUrun;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (lstUrunFotograflari.SelectedItem == null)
            {
                MessageBox.Show("Secim Yapınız.");
                return;
            }
            AdminUrunVM secilenUrun = (cmbUrunler.SelectedItem as AdminUrunVM);
            GeneralReturnType<AdminResimVM> generalReturnType = _adminResimBLL.Delete(lstUrunFotograflari.SelectedItem as AdminResimVM);
            if (generalReturnType.StatusCode!=200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message+": Resim Silindi");
            Temizle();
            cmbUrunler.SelectedItem = secilenUrun;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
