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
    public partial class AdminUrunIcerikUI : Form
    {
        AdminBilesenBLL _bilesenBLL = new AdminBilesenBLL();
        AdminUrunBLL _urunBLL = new AdminUrunBLL();
        AdminUrunIcerikBLL _urunIcerikBLL = new AdminUrunIcerikBLL();

        public AdminUrunIcerikUI()
        {
            InitializeComponent();
        }

        private void UrunIcerik_Load(object sender, EventArgs e)
        {
            //ub
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cmbUrunlerUB.DataSource = _urunBLL.GetList().Datas;
            cmbBilesenlerUB.DataSource = _bilesenBLL.GetList().Datas;

            cmbBilesenlerBU.DataSource = _bilesenBLL.GetList().Datas;
            cmbUrunlerBU.DataSource = _urunBLL.GetList().Datas;

            Temizle();

        }

        private void Temizle()
        {
            cmbBilesenlerBU.SelectedItem = cmbBilesenlerUB.SelectedItem = cmbUrunlerBU.SelectedItem = cmbUrunlerUB.SelectedItem = null;
            lstBilesenUrunleri.Items.Clear();
            lstUrunBilesenleri.Items.Clear();
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
        }
        private void cmbUrunlerUB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunBilesenleriListele();
        }
        private void cmbBilesenlerBU_SelectedIndexChanged(object sender, EventArgs e)
        {
            BilesenUrunleriListele();
        }


        private void UrunBilesenleriListele()
        {
            if (cmbUrunlerUB.SelectedItem == null)
            {
                return;
            }
            lstUrunBilesenleri.Items.Clear();
            lstUrunBilesenleri.Items.AddRange(_urunIcerikBLL.GetBilesenListWithUrunID(cmbUrunlerUB.SelectedItem as AdminUrunVM).Datas.ToArray());
        }
        private void BilesenUrunleriListele()
        {
            if (cmbBilesenlerBU.SelectedItem == null)
            {
                return;
            }
            lstBilesenUrunleri.Items.Clear();
            lstBilesenUrunleri.Items.AddRange(_urunIcerikBLL.GetBilesenListWithUrunID(cmbBilesenlerBU.SelectedItem as AdminBilesenVM).Datas.ToArray());
        }



        #region Ekle Urun-Bilesen
        private void btnEkleUrunBilesen_Click(object sender, EventArgs e)
        {
            if (cmbBilesenlerUB.SelectedItem == null || cmbUrunlerUB.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            GeneralReturnType<AdminUrunIcerikVM> generalReturnType = _urunIcerikBLL.Add(new AdminUrunIcerikVM()
            {
                BilesenID = (cmbBilesenlerUB.SelectedItem as AdminBilesenVM).ID,
                UrunID = (cmbUrunlerUB.SelectedItem as AdminUrunVM).ID,
                AktifMİ = chAktifMiUB.Checked
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Bilesen Urune Eklendi..");
            Temizle();
            UrunBilesenleriListele();
        }
        #endregion

        #region Ekle Bilesen-Urun
        private void btnEkleBilesenUrun_Click(object sender, EventArgs e)
        {
            if (cmbBilesenlerBU.SelectedItem == null || cmbUrunlerBU.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            GeneralReturnType<AdminUrunIcerikVM> generalReturnType = _urunIcerikBLL.Add(new AdminUrunIcerikVM()
            {
                BilesenID = (cmbBilesenlerBU.SelectedItem as AdminBilesenVM).ID,
                UrunID = (cmbUrunlerBU.SelectedItem as AdminUrunVM).ID,
                AktifMİ = chAktifMiBU.Checked
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Bilesen Urune Eklendi..");
            Temizle();
            UrunBilesenleriListele();
        }
        #endregion
       
        #region Sil Urun-Bilesen
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbUrunlerUB.SelectedItem == null || lstUrunBilesenleri.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminUrunIcerikVM> generalReturnType = _urunIcerikBLL.Delete(new AdminUrunIcerikVM()
                {
                    BilesenID = (lstUrunBilesenleri.SelectedItem as AdminBilesenVM).ID,
                    UrunID = (cmbUrunlerUB.SelectedItem as AdminUrunVM).ID,
                });
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Firma Urunden Silindi.");
                Temizle();
                UrunBilesenleriListele();
            }
        }
        #endregion
        
        #region Sil Bilesen-Urun
        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cmbBilesenlerBU.SelectedItem == null || lstBilesenUrunleri.SelectedItem == null)
            {
                MessageBox.Show("Secimlerinizi Yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminUrunIcerikVM> generalReturnType = _urunIcerikBLL.Delete(new AdminUrunIcerikVM()
                {
                    BilesenID = (cmbBilesenlerBU.SelectedItem as AdminBilesenVM).ID,
                    UrunID = (lstBilesenUrunleri.SelectedItem as AdminUrunVM).ID,
                });
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Firma Urunden Silindi.");
                Temizle();
                UrunBilesenleriListele();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

