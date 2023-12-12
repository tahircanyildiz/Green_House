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
using static System.Net.Mime.MediaTypeNames;

namespace GreenHouse.UI.AdminPanel.UI
{
    public partial class AdminRiskUI : Form
    {
        AdminRiskBLL riskBLL = new AdminRiskBLL();
        public AdminRiskUI()
        {
            InitializeComponent();
        }

        private void Risk_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Temizle();
            Listele();
        }

        private void Listele()
        {
            lstRisk.Items.Clear();
            GeneralReturnType<List<AdminRiskVM>> data = riskBLL.GetList();
            if (data.StatusCode != 200  )
            {
                MessageBox.Show(data.Message);
                return;
            }
            lstRisk.Items.AddRange(data.Datas.ToArray());
        }

        private void Temizle()
        {
           txtRiskAdi.Text = string.Empty;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AdminRiskVM eklenecekRisk = new AdminRiskVM()
            {
                RiskTur = txtRiskAdi.Text
            };
            GeneralReturnType<AdminRiskVM> generalReturnType = riskBLL.Add(eklenecekRisk);
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
            AdminRiskVM riskVM = lstRisk.SelectedItem as AdminRiskVM;

            if (riskVM == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminRiskVM> generalReturnType = riskBLL.HardDelete(riskVM);
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
            if (lstRisk.SelectedItem == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }

            AdminRiskVM guncellenekRisk = new AdminRiskVM()
            {
                RiskTur = txtRiskAdi.Text,
                AktifMi = cbAktifMi.Checked
            };
            GeneralReturnType<AdminRiskVM> generalReturnType = riskBLL.Update(guncellenekRisk);
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message);
            Temizle();
            Listele();
        }

        private void lstRisk_SelectedIndexChanged(object sender, EventArgs e)
        {

            AdminRiskVM secilenRisk = lstRisk.SelectedItem as AdminRiskVM;
            if (secilenRisk == null)
            {
                return;
            }
            txtRiskAdi.Text = secilenRisk.RiskTur.ToString();
            cbAktifMi.Checked =(bool)secilenRisk.AktifMi;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
