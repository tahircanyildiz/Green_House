using GreenHouse.BLL.AdminsBLL;
using GreenHouse.BLL.UsersBLL;
using GreenHouse.Core.Common;
using GreenHouse.UI.AdminPanel.UI.UrunEklemeFormlari;
using GreenHouse.UI.User;
using GreenHouse.VM.AdminVMs;
using GreenHouse.VM.VM;
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
    public partial class AdminUrunUI : Form
    {
        AdminUrunBLL _urunBLL = new AdminUrunBLL();
        AdminUrunFirmaBLL _urunFirma = new AdminUrunFirmaBLL();
        AdminUrunIcerikBLL _urunBilesen = new AdminUrunIcerikBLL();
        AdminResimBLL _resimBLL = new AdminResimBLL();
        AdminKategoriBLL _kategoriBLL = new AdminKategoriBLL();
        private List<AdminFirmaVM> secilenFirmalar = new List<AdminFirmaVM>();
        private List<AdminBilesenVM> secilenBilesenler = new List<AdminBilesenVM>();
        AdminResimVM onYuz;
        List<AdminResimVM> digerResimler = new List<AdminResimVM>();
        
        public AdminPanelUI AdminPanelUI { get; set; }
        public AdminUrunUI()
        {
            InitializeComponent();
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cmbKategoriler.DataSource = new AdminKategoriBLL().GetList().Datas;
            cmbKategoriler.SelectedItem = null;
            UrunleriListele();

        }

        private void UrunleriListele()
        {
            GeneralReturnType<List<AdminUrunVM>> urunler = null;
            if (!chSilinenleriGoster.Checked)
            {
                urunler = _urunBLL.GetList();
            }
            else
            {
                urunler = _urunBLL.GetListAktifler(); 
            }
             
            lstUrunler.Items.Clear();
            lstUrunler.Items.AddRange(urunler.Datas.ToArray());
            lblToplamUrunSayisi.Text = "Ürün sayısı :" + urunler.Datas.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirmaSec_Click(object sender, EventArgs e)
        {
            AdminUrunEkleFirma adminUrunEkleFirma = new AdminUrunEkleFirma();
            adminUrunEkleFirma.StartPosition = FormStartPosition.Manual;
            adminUrunEkleFirma.Location = new Point(
                (this.Location.X),
                (this.Location.Y)
            );

            secilenFirmalar = adminUrunEkleFirma.SecilenFirmalar;
            adminUrunEkleFirma.ShowDialog();
            if (secilenFirmalar == null)
            {
                return;
            }
            lblSecilenFirmaSayisi.Text = "( " + secilenFirmalar.Count + " )";
        }

        private void btnBilesenSec_Click(object sender, EventArgs e)
        {
            AdminUrunEkleBilesen adminUrunEkleBilesen = new AdminUrunEkleBilesen();
            adminUrunEkleBilesen.StartPosition = FormStartPosition.Manual;
            adminUrunEkleBilesen.Location = new Point(
                (this.Location.X),
                (this.Location.Y)
            );

            secilenBilesenler = adminUrunEkleBilesen.SecilenBilesenler;
            adminUrunEkleBilesen.ShowDialog();
            if (secilenBilesenler == null)
            {
                return;
            }
            lblSecilenBilesenSayisi.Text = "( " + secilenBilesenler.Count + " )";
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OnYuzSec();
        }
        private void OnYuzSec()
        {
            try
            {
                var file = openFileDialog1.ShowDialog() == DialogResult.OK;
                string onYuzResimYolu = openFileDialog1.FileName;

                if (file != true)
                {
                    MessageBox.Show("Resim secmediniz");
                    return;
                }
                onYuz = new AdminResimVM()
                {
                    ID = Guid.NewGuid(),
                    AktifMi = true,
                    ResimYolu = onYuzResimYolu,
                    ResimYuzu = true,
                };
                if (onYuz.ResimYolu.Length > 0)
                {
                    lblOnYuzSayisi.Text = "( 1 )";
                    return;
                }
                lblOnYuzSayisi.Text = "(  )";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDigerResimler_Click(object sender, EventArgs e)
        {
            DigerResimler();
        }
        private void DigerResimler()
        {
            try
            {
                List<string> selectedImageFiles = new List<string>();

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tüm Dosyalar|*.*";
                    openFileDialog.Multiselect = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Seçilen resim dosyalarının yollarını listeye ekleyin
                        selectedImageFiles.AddRange(openFileDialog.FileNames);
                    }
                }

                if (!(selectedImageFiles.Count <= 4 && selectedImageFiles.Count >= 1))
                {
                    MessageBox.Show("En az 1 en fazla 4 resim seçebilirsiniz..");
                    return;
                }
                digerResimler.Clear();
                foreach (var item in selectedImageFiles)
                {
                    digerResimler.Add(new AdminResimVM()
                    {
                        AktifMi = true,
                        ID = Guid.NewGuid(),
                        ResimYolu = item,
                        ResimYuzu = false
                    });
                }

                lblResimSayisi.Text = "( " + digerResimler.Count + " )";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            List<AdminResimVM> resimlers = new List<AdminResimVM>();
            if (onYuz == null)
            {
                MessageBox.Show("Secimlerinizi yapınız.");
                return;
            }
            if (onYuz.ResimYolu.Length < 1 || digerResimler.Count < 1)
            {
                MessageBox.Show("Bir önyüz ve en az bir tane daha resim seçmeniz gerekiyor.");
                return;
            }
            if (secilenFirmalar.Count <= 0)
            {
                MessageBox.Show("En az bir tane firma seçmeniz gerekiyor.");
                return;
            }
            if (secilenBilesenler.Count <= 0)
            {
                MessageBox.Show("En az bir tane bileşen seçmeniz gerekiyor.");
                return;
            }
            if (cmbKategoriler.SelectedItem == null)
            {
                MessageBox.Show("Kategori Seçiniz.");
                return;
            }
            resimlers.Add(onYuz);
            resimlers.AddRange(digerResimler);

            GeneralReturnType<AdminUrunVM> generalReturnType = _urunBLL.UrunEkleTransaction(new AdminUrunVM()
            {
                UrunAdi = txtUrunAdi.Text,
                ID = Guid.NewGuid(),
                AktifMi = true,
                BarkodNumarasi = txtBarkodNo.Text,
                UrunAciklamasi = txtAciklama.Text,
                KategoriID = (cmbKategoriler.SelectedItem as AdminKategoriVM).ID
            }, secilenFirmalar, secilenBilesenler, resimlers);

            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Ürün başarı ile eklendi.");
            UrunleriListele();
            Temizle();
        }

        private void Temizle()
        {
            txtAciklama.Text = txtBarkodNo.Text = txtUrunAdi.Text = string.Empty;
            cmbKategoriler.SelectedItem = null;
            secilenBilesenler.Clear();
            secilenFirmalar.Clear();
            onYuz = null;
            digerResimler.Clear();
            lblOnYuzSayisi.Text = lblResimSayisi.Text = lblSecilenBilesenSayisi.Text = lblSecilenFirmaSayisi.Text = "(  )";
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminUrunVM secilenUrun = lstUrunler.SelectedItem as AdminUrunVM;
            if (secilenUrun == null)
            {
                return;
            }


            txtAciklama.Text = secilenUrun.UrunAciklamasi;
            txtBarkodNo.Text = secilenUrun.BarkodNumarasi;
            txtUrunAdi.Text = secilenUrun.UrunAdi;
            if (secilenUrun.AktifMi==null)
            {
                cbUretiliyorMu.Checked = false;
            }
            else
            {
                cbUretiliyorMu.Checked = (bool)secilenUrun.AktifMi;
            }
            secilenFirmalar.Clear();
            secilenBilesenler.Clear();
            secilenFirmalar = _urunFirma.GetFirmaListWithUrunID(secilenUrun).Datas;
            secilenBilesenler = _urunBilesen.GetBilesenListWithUrunID(secilenUrun).Datas;
            onYuz = _resimBLL.GetResimlerWithUrunID(secilenUrun).Datas.Where(x => x.ResimYuzu == true).FirstOrDefault();
            digerResimler = _resimBLL.GetResimlerWithUrunID(secilenUrun).Datas.Where(x => x.ResimYuzu == false).ToList();
            cmbKategoriler.SelectedItem= cmbKategoriler.Items.OfType<AdminKategoriVM>().FirstOrDefault(x => x.ID == secilenUrun.KategoriID);
            lblOnYuzSayisi.Text = onYuz != null ? "( 1 )" : "( )";
            lblSecilenBilesenSayisi.Text = "( " + secilenBilesenler.Count + " )";
            lblSecilenFirmaSayisi.Text = "( " + secilenFirmalar.Count + " )";
            lblResimSayisi.Text = "( " + digerResimler.Count + " )";

           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            AdminUrunVM secilenUrun = lstUrunler.SelectedItem as AdminUrunVM;
            List<AdminResimVM> resimlers = new List<AdminResimVM>();
            if (secilenUrun == null)
            {
                MessageBox.Show("Once Urun Seciniz.");
                return;
            }
            if (onYuz == null)
            {
                MessageBox.Show("Secimlerinizi yapınız.");
                return;
            }
            if (onYuz.ResimYolu.Length < 1 || digerResimler.Count < 1)
            {
                MessageBox.Show("Bir önyüz ve en az bir tane daha resim seçmeniz gerekiyor.");
                return;
            }
            if (secilenFirmalar.Count <= 0)
            {
                MessageBox.Show("En az bir tane firma seçmeniz gerekiyor.");
                return;
            }
            if (secilenBilesenler.Count <= 0)
            {
                MessageBox.Show("En az bir tane bileşen seçmeniz gerekiyor.");
                return;
            }
            if (cmbKategoriler.SelectedItem == null)
            {
                MessageBox.Show("Kategori Seçiniz.");
                return;
            }
            resimlers.Add(onYuz);
            resimlers.AddRange(digerResimler);

            GeneralReturnType<AdminUrunVM> generalReturnType = _urunBLL.UrunGuncelleTransaction(new AdminUrunVM()
            {
                UrunAdi = txtUrunAdi.Text,
                ID = secilenUrun.ID,
                AktifMi = true,
                BarkodNumarasi = txtBarkodNo.Text,
                UrunAciklamasi = txtAciklama.Text,
                KategoriID = (cmbKategoriler.SelectedItem as AdminKategoriVM).ID
            }, secilenFirmalar, secilenBilesenler, resimlers);

            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Ürün başarı ile guncellendi.");
            UrunleriListele();
            Temizle();





        }

        private void lstUrunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            AdminUrunVM secilenUrun = lstUrunler.SelectedItem as AdminUrunVM;
            if (secilenUrun == null)
            {
                return;
            }

            ProductContent productContent = new ProductContent(new UserUrunBLL().IDIleGetirBLL(secilenUrun.ID));
            productContent.StartPosition = FormStartPosition.Manual;
            productContent.Location = new Point(
                (this.Location.X - productContent.Size.Width),
                (this.Location.Y)
            );
            productContent.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUrunVM secilenUrun = lstUrunler.SelectedItem as AdminUrunVM;
            List<AdminResimVM> resimlers = new List<AdminResimVM>();
            if (secilenUrun == null)
            {
                MessageBox.Show("Once Urun Seciniz.");
                return;
            }
            resimlers.Add(onYuz);
            resimlers.AddRange(digerResimler);
            GeneralReturnType<AdminUrunVM> generalReturnType = _urunBLL.SoftDelete(new AdminUrunVM()
            {
                UrunAdi = txtUrunAdi.Text,
                ID = secilenUrun.ID,
                AktifMi = secilenUrun.AktifMi,
                BarkodNumarasi = txtBarkodNo.Text,
                UrunAciklamasi = txtAciklama.Text,
                KategoriID = (cmbKategoriler.SelectedItem as AdminKategoriVM).ID
            });

            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Ürün başarı ile silindi.");
            UrunleriListele();
            Temizle();
        }

        private void chSilinenleriGoster_CheckedChanged(object sender, EventArgs e)
        {
            UrunleriListele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            UrunleriListele();
        }
    }
}
