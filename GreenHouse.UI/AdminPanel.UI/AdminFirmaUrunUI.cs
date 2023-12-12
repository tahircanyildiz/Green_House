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
    public partial class AdminFirmaUrunUI : Form
    {
        AdminUrunBLL _urunBLL = new AdminUrunBLL();
        AdminFirmaBLL _firmaBLL = new AdminFirmaBLL();
        AdminUrunFirmaBLL _urunfirmaBLL = new AdminUrunFirmaBLL();
        public AdminFirmaUrunUI()
        {
            InitializeComponent();
        }

        private void FirmaUrun_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cmbFirmalarFU.DataSource = _firmaBLL.GetList().Datas;
            cmbFirmalarUF.DataSource = _firmaBLL.GetList().Datas;
            cmbUrunlerFU.DataSource = _urunBLL.GetList().Datas;
            cmbUrunlerUF.DataSource = _urunBLL.GetList().Datas;
            cmbFirmalarFU.SelectedItem = cmbUrunlerFU.SelectedItem = cmbFirmalarUF.SelectedItem = cmbUrunlerUF.SelectedItem = null;
            
        }


        #region Firma-Urun Ekle

        private void btnEkleFirmaUrun_Click(object sender, EventArgs e)
        {
            if (cmbFirmalarFU.SelectedItem == null || cmbUrunlerFU.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            GeneralReturnType<AdminUrunFirmaVM> generalReturnType = _urunfirmaBLL.Add(new AdminUrunFirmaVM()
            {
                FirmaID = (cmbFirmalarFU.SelectedItem as AdminFirmaVM).ID,
                UrunID = (cmbUrunlerFU.SelectedItem as AdminUrunVM).ID,
                AktifMi = true
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Firma Urune Eklendi..");
            Temizle();
            UrunFirmalariListele();
        } 
        #endregion

        #region Firma-Urun Sil
        
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbFirmalarFU.SelectedItem == null || lstFirmaUrunleri.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminUrunFirmaVM> generalReturnType = _urunfirmaBLL.Delete(new AdminUrunFirmaVM()
                {
                    FirmaID = (cmbFirmalarFU.SelectedItem as AdminFirmaVM).ID,
                    UrunID = (lstFirmaUrunleri.SelectedItem as AdminUrunVM).ID
                });
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Firma Urunden Silindi.");
                Temizle();
                UrunFirmalariListele();
            }

        } 
        #endregion
        
        #region Urun-Firma Ekle
        private void btnEkleUrunFirma_Click(object sender, EventArgs e)
        {
            if (cmbUrunlerUF.SelectedItem == null || cmbFirmalarUF.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            GeneralReturnType<AdminUrunFirmaVM> generalReturnType = _urunfirmaBLL.Add(new AdminUrunFirmaVM()
            {
                FirmaID = (cmbFirmalarUF.SelectedItem as AdminFirmaVM).ID,
                UrunID = (cmbUrunlerUF.SelectedItem as AdminUrunVM).ID,
                AktifMi = true
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Firma Urune Eklendi..");
            Temizle();
            UrunFirmalariListele();
        }
        #endregion

        #region Urun-Firma Sil
        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cmbUrunlerUF.SelectedItem == null || lstUrunFirmalari.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminUrunFirmaVM> generalReturnType = _urunfirmaBLL.Delete(new AdminUrunFirmaVM()
                {
                    FirmaID = (lstUrunFirmalari.SelectedItem as AdminFirmaVM).ID,
                    UrunID = (cmbUrunlerUF.SelectedItem as AdminUrunVM).ID
                });
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Firma Urunden Silindi.");
                Temizle();
                UrunFirmalariListele();
            }

        } 
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            cmbUrunlerUF.SelectedItem = cmbUrunlerFU.SelectedItem = cmbFirmalarUF.SelectedItem = cmbFirmalarFU.SelectedItem = null;
            lstFirmaUrunleri.Items.Clear();
            lstUrunFirmalari.Items.Clear();
        }
        private void cmbUrunlerUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrunlerUF.SelectedItem == null)
            {
                return;
            }
            UrunFirmalariListele();
        }
        private void cmbFirmalarFU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFirmalarFU.SelectedItem == null)
            {
                return;
            }
            FirmaUrunleriListele();
        }
        private void UrunFirmalariListele()
        {
            if (cmbUrunlerUF.SelectedItem == null)
            {
                return;
            }
            lstUrunFirmalari.Items.Clear();
            lstUrunFirmalari.Items.AddRange(_urunfirmaBLL.GetFirmaListWithUrunID(cmbUrunlerUF.SelectedItem as AdminUrunVM).Datas.ToArray());
        }
        private void FirmaUrunleriListele()
        {
            if (cmbFirmalarFU.SelectedItem==null)
            {
                return;
            }
            lstFirmaUrunleri.Items.Clear();
            lstFirmaUrunleri.Items.AddRange(_urunfirmaBLL.GetUrunListWithFirmaID(cmbFirmalarFU.SelectedItem as AdminFirmaVM).Datas.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
