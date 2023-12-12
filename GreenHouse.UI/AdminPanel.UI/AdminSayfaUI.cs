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
    public partial class AdminSayfaUI : Form
    {
        AdminSayfaBLL _sayfaBLL = new AdminSayfaBLL();
        public AdminSayfaUI()
        {
            InitializeComponent();
        }

        private void AdminSayfaUI_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            SayfalariListele();
        }

        private void SayfalariListele()
        {
            lstSayfalar.Items.Clear();
            lstSayfalar.Items.AddRange(_sayfaBLL.GetAll().Datas.ToArray());
        }

        private void lstSayfalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSayfalar.SelectedItem ==null)
            {
                return;
            }
            txtSayfaAdi.Text = (lstSayfalar.SelectedItem as AdminSayfaVM).SayfaAdi;
        }

        private void btnSayfaAra_Click(object sender, EventArgs e)
        {
            lstSayfalar.Items.Clear();
            lstSayfalar.Items.AddRange(_sayfaBLL.GetSayfalarWithName(txtSayfaAdi.Text).Datas.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayfalariListele();
            Temizle();
        }

        private void Temizle()
        {
            txtSayfaAdi.Text = string.Empty;
        }

        private void btnSayfaEkle_Click(object sender, EventArgs e)
        {
            GeneralReturnType<AdminSayfaVM> generalReturnType = _sayfaBLL.Add(new AdminSayfaVM()
            {
                SayfaAdi = txtSayfaAdi.Text
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Sayfa Eklendi");
            SayfalariListele();
            Temizle();
        }

        private void btnSayfaGuncelle_Click(object sender, EventArgs e)
        {
            if (lstSayfalar.SelectedItem == null)
            {
                MessageBox.Show("Seçim yapınız.");
                return;
            }
            GeneralReturnType<AdminSayfaVM> generalReturnType = _sayfaBLL.Update(new AdminSayfaVM()
            {
               SayfaAdi=txtSayfaAdi.Text,
               ID= (lstSayfalar.SelectedItem as AdminSayfaVM).ID
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Sayfa Guncellendi");
            SayfalariListele();
            Temizle();
        }

        private void sayfaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstSayfalar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminSayfaVM> generalReturnType = _sayfaBLL.Delete(lstSayfalar.SelectedItem as AdminSayfaVM);
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Sayfa Silindi.");
                Temizle();
                SayfalariListele();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
