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
    public partial class AdminFirmaUI : Form
    {
        AdminFirmaBLL _adminFirmaBLL = new AdminFirmaBLL();

        public AdminFirmaUI()
        {
            InitializeComponent();
        }

        private void Firma_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            GeneralReturnType<AdminFirmaVM> generalReturnType= _adminFirmaBLL.Add(new AdminFirmaVM()
            {
                ID = Guid.NewGuid(),
                FirmaAdi = txtFirmaAdi.Text,
                FirmaTel=txtTelNo.Text,
                FirmaAdresi=txtAdres.Text,
                AktifMi=chAktifMi.Checked,
                
            });
            if (generalReturnType.StatusCode!=200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message+": Firma Eklendi.");
            Temizle();
            Listele();
        }

        private void Listele()
        {
            lstFirmalar.Items.Clear();
            lstFirmalar.Items.AddRange(_adminFirmaBLL.GetList().Datas.ToArray());
        }

        private void Temizle()
        {
            txtFirmaAdi.Text = txtFirmaID.Text = txtAdres.Text = txtTelNo.Text = string.Empty;
            chAktifMi.Checked = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GeneralReturnType<AdminFirmaVM> generalReturnType = _adminFirmaBLL.Update(new AdminFirmaVM()
            {
                ID = Guid.Parse(txtFirmaID.Text),
                FirmaAdi = txtFirmaAdi.Text,
                FirmaTel = txtTelNo.Text,
                FirmaAdresi = txtAdres.Text,
                AktifMi = chAktifMi.Checked
            });
            if (generalReturnType.StatusCode!=200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message+": Firma Guncellendi.");
            Temizle();
            Listele();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminFirmaVM adminFirmaVM = lstFirmalar.SelectedItem as AdminFirmaVM;

            if (adminFirmaVM == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminFirmaVM> generalReturnType = _adminFirmaBLL.Delete(adminFirmaVM);
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Firma Silindi.");
                Temizle();
                Listele();
            }
        }

        private void lstFirmalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminFirmaVM secilenFirma = lstFirmalar.SelectedItem as AdminFirmaVM;
            txtFirmaID.Text = secilenFirma.ID.ToString();
            txtFirmaAdi.Text = secilenFirma.FirmaAdi;
            txtTelNo.Text = secilenFirma.FirmaTel;
            txtAdres.Text = secilenFirma.FirmaAdresi;
            chAktifMi.Checked = (bool)secilenFirma.AktifMi;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
