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
    public partial class AdminYetkiUI : Form
    {
        AdminYetkiBLL _yetkiBLL = new AdminYetkiBLL();
        public AdminYetkiUI()
        {
            InitializeComponent();
        }

        private void AdminYetkiUI_Load(object sender, EventArgs e)
        {

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Listele();
        }

        private void Listele()
        {
            lstYetkiler.Items.Clear();
            lstYetkiler.Items.AddRange(_yetkiBLL.GetAll().Datas.ToArray());
        }

        private void lstYetkiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYetkiler.SelectedItem == null)
            {
                return;
            }
            txtYetkiAdi.Text = (lstYetkiler.SelectedItem as AdminYetkiVM).Adi;
        }

        private void btnYetkiAra_Click(object sender, EventArgs e)
        {
            lstYetkiler.Items.Clear();
            lstYetkiler.Items.AddRange(_yetkiBLL.GetYetkilerWithName(txtYetkiAdi.Text).Datas.ToArray());
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (lstYetkiler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminYetkiVM> generalReturnType = _yetkiBLL.Delete(lstYetkiler.SelectedItem as AdminYetkiVM);
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Yetki Silindi.");
                Temizle();
                Listele();
            }
        }

        private void btnYetkiEkle_Click(object sender, EventArgs e)
        {
            GeneralReturnType<AdminYetkiVM> generalReturnType = _yetkiBLL.Add(new AdminYetkiVM()
            {
                Adi = txtYetkiAdi.Text
            });
            if (generalReturnType.StatusCode!=200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message+": Yetki Eklendi");
            Listele();
            Temizle();
        }

        private void btnYetkiGuncelle_Click(object sender, EventArgs e)
        {
            if (lstYetkiler.SelectedItem == null)
            {
                MessageBox.Show("Seçim yapınız.");
                return;
            }
            GeneralReturnType<AdminYetkiVM> generalReturnType = _yetkiBLL.Update(new AdminYetkiVM()
            {
                ID=(lstYetkiler.SelectedItem as AdminYetkiVM).ID,
                Adi = txtYetkiAdi.Text
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Yetki Guncellendi");
            Listele();
            Temizle();
        }

        private void btnFiltreTemizle_Click(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void Temizle()
        {
            txtYetkiAdi.Text = string.Empty;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
