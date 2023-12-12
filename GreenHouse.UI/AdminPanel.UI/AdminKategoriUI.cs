using GreenHouse.BLL.AdminsBLL;
using GreenHouse.Core.Common;
using GreenHouse.VM.AdminVMs;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.AdminPanel.UI
{
    public partial class AdminKategoriUI : Form
    {
        AdminKategoriBLL kategoriBLL;
        public AdminKategoriUI()
        {
            InitializeComponent();
            kategoriBLL= new AdminKategoriBLL();
        }

        private void Listele()
        {
            lstKategoriler.Items.Clear();
            lstKategoriler.Items.AddRange(kategoriBLL.GetList().Datas.ToArray());

            cmbKategoriler.Items.Clear();
            cmbKategoriler.Items.AddRange(kategoriBLL.UstKategoriler().Datas.ToArray());
        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Listele();

        }
        private void Temizle()
        {
            cmbKategoriler.SelectedItem = null;
            txtKategoriAdı.Text = string.Empty;
        }

        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminKategoriVM secilenKategori = lstKategoriler.SelectedItem as AdminKategoriVM;
            if (secilenKategori == null)
            {
                return;
            }
            txtKategoriAdı.Text = secilenKategori.KategoriAdi;
            cbAnaKategoriMi.Checked = (secilenKategori.ID == secilenKategori.UstKategoriID) ? true : false;
            cbAktifMi.Checked = (bool)secilenKategori.AktifMi;
            cmbKategoriler.SelectedItem = kategoriBLL.GetUstKategoriByID((int)secilenKategori.UstKategoriID).Datas;
            cmbKategoriler.SelectedItem = cmbKategoriler.Items.OfType<AdminKategoriVM>().FirstOrDefault(x => x.ID == secilenKategori.UstKategoriID);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AdminKategoriVM eklenecekKategori = new AdminKategoriVM();
            GeneralReturnType<AdminKategoriVM> generalReturnType;
            if (cbAnaKategoriMi.Checked)
            {
                cmbKategoriler.SelectedItem = null;


                eklenecekKategori.KategoriAdi=txtKategoriAdı.Text;
                eklenecekKategori.AktifMi = cbAktifMi.Checked;
                generalReturnType = kategoriBLL.UstKategory(eklenecekKategori);
            }
            else
            {
                eklenecekKategori.KategoriAdi = txtKategoriAdı.Text;
                eklenecekKategori.UstKategoriID = (cmbKategoriler.SelectedItem as AdminKategoriVM).ID;
                eklenecekKategori.AktifMi = cbAktifMi.Checked;
                generalReturnType = kategoriBLL.Add(eklenecekKategori);
            }       

            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message);
            Temizle();
            Listele();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKategoriVM AdminKategoriVM = lstKategoriler.SelectedItem as AdminKategoriVM;

            if (AdminKategoriVM == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminKategoriVM> generalReturnType = kategoriBLL.HardDelete(AdminKategoriVM);
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message);
                Temizle();
                Listele();
            }
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedItem == null)
            { 
                return;
            }
            lstKategoriler.Items.Clear();
            lstKategoriler.Items.AddRange(kategoriBLL.AltKategorileriGetir((cmbKategoriler.SelectedItem as AdminKategoriVM).ID).Datas.ToArray());
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            int id = (lstKategoriler.SelectedItem as AdminKategoriVM).ID;
            GeneralReturnType<AdminKategoriVM> generalReturnType;
            if (cbAnaKategoriMi.Checked)
            {
                AdminKategoriVM guncellenecekKategori = new AdminKategoriVM
                {
                    ID = id,
                    KategoriAdi = txtKategoriAdı.Text,
                    AktifMi = cbAktifMi.Checked,
                    UstKategoriID = id,
                };
                generalReturnType = kategoriBLL.Update(guncellenecekKategori);
            }
            else
            {
                AdminKategoriVM guncellenecekKategori = new AdminKategoriVM
                {
                    ID = id,
                    UstKategoriID = (cmbKategoriler.SelectedItem as UrunKategori).ID,
                    KategoriAdi = txtKategoriAdı.Text,
                    AktifMi = cbAktifMi.Checked
                };
                generalReturnType = kategoriBLL.Update(guncellenecekKategori);
            }
           
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message);
            Temizle();
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kategori Adı ile arama yapabilirsiniz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnKategoriAra_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdı.Text == null)
            {
                MessageBox.Show("Lütfen Kategori Adı alanını doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lstKategoriler.Items.Clear();
            lstKategoriler.Items.AddRange(kategoriBLL.GetKategorilerWithName(txtKategoriAdı.Text).Datas.ToArray());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen, güncelleme işlemi yapmak için liste üzerinde seçim yaptığınızdan emin olunuz. Tüm Kategorileri listelemek için Temizle butonuna basabilirsiniz. ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
