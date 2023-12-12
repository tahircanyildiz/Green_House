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

namespace GreenHouse.UI.AdminPanel.UI.UrunEklemeFormlari
{
    public partial class AdminUrunEkleBilesen : Form
    {
        AdminBilesenBLL _bilesenBLL = new AdminBilesenBLL();
        AdminRiskBLL _risk = new AdminRiskBLL();
        public List<AdminBilesenVM> SecilenBilesenler { get; private set; }
        public AdminUrunEkleBilesen()
        {
            InitializeComponent();
            SecilenBilesenler = new List<AdminBilesenVM>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminUrunEkleBilesen_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cmbRiskler.DataSource = _risk.GetList().Datas;

            cmbRiskler.SelectedItem = null;
            BilesenleriListele();
        }

        private void BilesenleriListele()
        {
            lstBilesenler.Items.Clear();
            lstBilesenler.Items.AddRange(_bilesenBLL.GetList().Datas.ToArray());
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (lstBilesenler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lutfen secim yapınız.");
                return;
            }

            SecilenBilesenler.Clear();
            foreach (var item in lstBilesenler.SelectedItems)
            {
                if (item is AdminBilesenVM bilesen)
                {
                    SecilenBilesenler.Add(bilesen);
                }
            }
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            BilesenleriListele();
            Temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            lstBilesenler.Items.Clear();
            lstBilesenler.Items.AddRange(_bilesenBLL.GetListWithName(txtBilesenAdi.Text).Datas.ToArray());
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbRiskler.SelectedItem == null)
            {
                MessageBox.Show("Risk düzeyi seçiniz.");
                return;
            }
            AdminBilesenVM eklenecekBilesen = new AdminBilesenVM()
            {
                ID = Guid.NewGuid(),
                Adi = txtBilesenAdi.Text,
                Aciklama = txtAciklama.Text,
                RiskID = (cmbRiskler.SelectedItem as AdminRiskVM).ID
            };
            GeneralReturnType<AdminBilesenVM> generalReturnType = _bilesenBLL.Add(eklenecekBilesen);
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Bileşen Eklendi.");
            BilesenleriListele();
            Temizle();
        }

        private void Temizle()
        {
            txtAciklama.Text = txtBilesenAdi.Text = string.Empty;
            cmbRiskler.SelectedItem = null;
        }
    }
}
