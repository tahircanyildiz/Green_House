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
    public partial class AdminUrunEkleFirma : Form
    {
        AdminFirmaBLL _firmaBLL = new AdminFirmaBLL();

        public List<AdminFirmaVM> SecilenFirmalar { get; private set; }
        public AdminUrunEkleFirma()
        {
            InitializeComponent();
          SecilenFirmalar = new List<AdminFirmaVM>();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void AdminUrunEkleFirma_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            FirmalariListele();
            

        }

        private void FirmalariListele()
        {
            
            lstFirmalar.Items.Clear();
            lstFirmalar.Items.AddRange(_firmaBLL.GetList().Datas.ToArray());
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (lstFirmalar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lutfen secim yapınız.");
                return;
            }

            SecilenFirmalar.Clear();
            foreach (var item in lstFirmalar.SelectedItems)
            {
                if (item is AdminFirmaVM firma)
                {
                    SecilenFirmalar.Add(firma);
                }
            }
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            lstFirmalar.Items.Clear();
            lstFirmalar.Items.AddRange(_firmaBLL.GetListWithName(txtFirmaAdi.Text).Datas.ToArray()) ;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FirmalariListele();
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            GeneralReturnType<AdminFirmaVM> generalReturnType = _firmaBLL.Add(new AdminFirmaVM()
            {
                ID = Guid.NewGuid(),
                FirmaAdi = txtFirmaAdi.Text,
                FirmaTel = txtTelNo.Text,
                FirmaAdresi = txtAdres.Text,
                AktifMi = true,

            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Firma Eklendi");
            FirmalariListele();
            Temizle();
        }

        private void Temizle()
        {
            txtAdres.Text = txtFirmaAdi.Text = txtTelNo.Text = string.Empty;
        }
    }
}
