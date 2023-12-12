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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.AdminPanel.UI
{
    public partial class AdminBilesenUI : Form
    {
        AdminBilesenBLL bilesenBLL = new AdminBilesenBLL();
        AdminRiskBLL riskBLL = new AdminRiskBLL();
        public AdminBilesenUI()
        {
            InitializeComponent();
        }



        private void Bilesen_Load(object sender, EventArgs e)
        {
            Listele();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            List<AdminRiskVM> data  =riskBLL.GetList().Datas;
            if (data ==null)
            {
                return;
            }
            cmbRiskler.Items.AddRange(data.ToArray());
            
        }


        private void Listele()
        {
            lstBilesen.Items.Clear();
            if (riskBLL.GetList().StatusCode != 200)
            {
                MessageBox.Show(riskBLL.GetList().Message);
                return;
            }
            lstBilesen.Items.AddRange(bilesenBLL.GetList().Datas.ToArray());
        }

        private void Temizle()
        {
            txtBilesenAdi.Text = txtAciklama.Text = string.Empty;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AdminBilesenVM eklenecekBilesen = new AdminBilesenVM()
            {
                ID = Guid.NewGuid(),
                Adi = txtBilesenAdi.Text,
                Aciklama = txtAciklama.Text,
            };
            GeneralReturnType<AdminBilesenVM> generalReturnType = bilesenBLL.Add(eklenecekBilesen);
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
            AdminBilesenVM bilesenVM = lstBilesen.SelectedItem as AdminBilesenVM;

            if (bilesenVM == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminBilesenVM> generalReturnType = bilesenBLL.HardDelete(bilesenVM);
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstBilesen.SelectedItem == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }

            AdminBilesenVM guncellenecekBilesen = new AdminBilesenVM()
            {
                ID = (lstBilesen.SelectedItem as AdminBilesenVM).ID,
                RiskID = (cmbRiskler.SelectedItem as AdminRiskVM).ID,
                Aciklama = txtAciklama.Text,
                AktifMi = cbAktifMi.Checked,
                Adi = txtBilesenAdi.Text
                

            };
            GeneralReturnType<AdminBilesenVM> generalReturnType = bilesenBLL.Update(guncellenecekBilesen);
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message);
            Temizle();
            Listele();
        }

        private void lstBilesen_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminBilesenVM secilenBilesen = lstBilesen.SelectedItem as AdminBilesenVM;
            if (secilenBilesen == null)
            {
                return;
            }
            txtAciklama.Text = secilenBilesen?.Aciklama;
            txtBilesenAdi.Text = secilenBilesen.Adi;
            cbAktifMi.Checked = (bool)secilenBilesen?.AktifMi;
            cmbRiskler.SelectedItem = cmbRiskler.Items.OfType<AdminRiskVM>().FirstOrDefault(x => x.ID == secilenBilesen.RiskID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
