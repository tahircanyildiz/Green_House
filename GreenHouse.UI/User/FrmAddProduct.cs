using GreenHouse.BLL;
using GreenHouse.BLL.AdminsBLL;
using GreenHouse.BLL.UsersBLL;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.UI.User;
using GreenHouse.VM.User;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.UserUI
{
    public partial class FrmAddProduct : Form
    {
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        private int num;
        private Random r = new Random();
        private List<string> resimYollari = new List<string>();
        private List<FirmaVM> firmaVMs = new List<FirmaVM>();
        private FrmUserProductView frmUserProductView;
        private List<Tuple<string, int, string>> values = new List<Tuple<string, int, string>>();
        private FrmUserBilesen userBilesen;
        private FrmUserResim userResim;
        public FrmAddProduct()
        {
            InitializeComponent();
        }


        private void BtnFrontProduct_Click(object sender, EventArgs e)
        {
            ResimEkle();
        }


        private void BtnSend_Click(object sender, EventArgs e)
        {

            //try
            //{

            //        var eklenenUrun = new UserUrunBLL().EkleUrunBLL(new VM.VM.UrunVM()
            //        {
            //            ID = Guid.NewGuid(),
            //            KategoriID = (cmbKategori.SelectedItem as KategoriVM).ID,
            //            UrunAdi = txtUrunAdi.Text,
            //            BarkodNumarasi = txtBarkod.Text
            //        });
            //        new UrunFirmaBLL().EkleUrunFirmaBLL(new UrunFirmaVM()
            //        {
            //            FirmaID = (cmbUretici.SelectedItem as FirmaVM).ID,
            //            UrunID = eklenenUrun.ID
            //        });
            //        string[] parcalar = txtBilesen.Text.Split(' ');
            //        foreach (var item in parcalar)
            //        {
            //            var data = new BilesenBLL().BilesenEkleBLL(new BilesenVM()
            //            {
            //                ID = Guid.NewGuid(),
            //                Adi = item,
            //                RiskID = r.Next(0, 5)
            //            });

            //            new UrunBilesenBLL().UrunIcerikEkleBLL(new UrunBilesenVM()
            //            {
            //                UrunID = eklenenUrun.ID,
            //                BilesenID = data.ID
            //            });
            //        }

            //        MessageBox.Show("Ürününüz Eklenmiştir");




            //}
            //catch
            //{
            //    MessageBox.Show("Ürün Eklenememiştir");
            //}

            UrunEkle();

        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            lstUretici.Items.AddRange(new UrunFirmaBLL().FirmaGetirBLL().ToArray());
            cmbKategori.DataSource = new KategoriBLL().GetirKategoriBLL();
            cmbBilesen.Items.AddRange(new UserRiskBLL().TumRiskGetir().ToArray());
            
        }

        private void Btnİcerik_Click(object sender, EventArgs e)
        {
            
            try
            {                
                if(values.Exists(t => t.Item1 == txtBilesen.Text))
                {
                    MessageBox.Show("Bu bileseni zaten eklediniz");
                }
                else if(txtBilesen.Text.ControlNullOrWhiteSpaceAndLength(50) && cmbBilesen.SelectedItem != null && txtBilesenAciklama.Text.ControlNullOrWhiteSpaceAndLength(200))
                {
                    Tuple<string, int, string> tuple = new Tuple<string, int, string>(txtBilesen.Text, (cmbBilesen.SelectedItem as RiskVM).ID, txtBilesenAciklama.Text);
                    values.Add(tuple);
                    MessageBox.Show("Bilesen eklenmistir");
                    lblBilesenSayisi.Text = values.Count.ToString();
                    txtBilesen.Text = null;
                    txtBilesenAciklama.Text = null;
                    cmbBilesen.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Lütfen gerekli yerleri doldurunuz.");
                }
                
                
            }
            catch
            {
                MessageBox.Show("Herhangi bir text seçmediniz");
            }
            
        }

        private void BtnUrunAciklama_Click(object sender, EventArgs e)
        {
            try
            {
                var file = openFileDialog1.ShowDialog() == DialogResult.OK;
                if (file)
                {
                    string fileName = openFileDialog1.FileName;
                    string readFile = File.ReadAllText(fileName);
                    txtUrunAciklama.Text = readFile;
                }
                else
                {
                    MessageBox.Show("Bir Text secmediniz");
                }
            }
            catch
            {
                MessageBox.Show("Herhangi bir text seçmediniz");
            }
        }

        private void ResimEkle()
        {
            try
            {
                var file = openFileDialog1.ShowDialog() == DialogResult.OK;
                string onYuzResimYolu;
                if(resimYollari.Count < 5 && file == true)
                {
                    onYuzResimYolu = openFileDialog1.FileName;
                    resimYollari.Add(onYuzResimYolu);
                    lblResimSayisi.Text = resimYollari.Count.ToString();
                }
                else if(file != true)
                {
                    MessageBox.Show("Resim secmediniz");
                }
                else
                {
                    MessageBox.Show("5 resimden fazla secemezsiniz");
                }                               

            }
            catch
            {
                
                MessageBox.Show("Herhangi bir resim seçmediniz");
            }
        }

        private void UrunEkle()
        {
            try
            {
                
                List<UrunFirmaVM> urunFirmaVMs = new List<UrunFirmaVM>();
                firmaVMs.AddRange(lstUretici.CheckedItems.OfType<FirmaVM>());
                if(new UserUrunBLL().UrunVarMi(txtUrunAdi.Text))
                {
                    MessageBox.Show("Girmeye calistiginiz urun zaten mevcut");
                }
                else if(values.Count == 0)
                {
                    MessageBox.Show("Lütfen Bilesen Giriniz");
                }
                else if(lstUretici.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Lütfen Uretici Seciniz");
                }
                else if (txtUrunAdi.Text.ControlNullOrWhiteSpaceAndLength(100) && txtUrunAciklama.Text.ControlNullOrWhiteSpaceAndLength(500) && txtBarkod.Text.ControlNullOrWhiteSpaceAndLength(40) &&  cmbKategori.SelectedItem != null)
                {
                    var eklenenUrun = new UrunVM()
                    {
                        ID = Guid.NewGuid(),
                        UrunAdi = txtUrunAdi.Text,
                        UrunAciklamasi = txtUrunAciklama.Text,
                        KategoriID = (cmbKategori.SelectedItem as KategoriVM).ID,
                        AktifMi = true,
                        OlusturanKullaniciRolID = gelenUser.Datas.KullaniciRoluID,
                        OlusturulmaTarihi = DateTime.Now,
                        BarkodNumarasi = txtBarkod.Text
                    };
                    var urunOnay = new UrunOnayInsertVM()
                    {
                        ID = Guid.NewGuid(),
                        TakipNumarasi = r.Next(1000, 20000000).ToString(),
                        KullaniciGozukmeDurumu = chcIsim.Checked,
                        EkleyenKullaniciRolID = gelenUser.Datas.KullaniciRoluID,
                        InceleyenKullaniciRolID = Guid.Parse("ddd6146e-a398-41a8-9aa0-e1736a5bbba1"),
                        OnayDurumu = null
                    };

                    
                    

                    if (new UserUrunBLL().UrunFirmaEkleTransaction(eklenenUrun, firmaVMs, urunOnay, resimYollari) && new BilesenBLL().UrunBilesenEkleTransaction(values, eklenenUrun))
                    {

                        MessageBox.Show("Urununuz basariyla eklendi");
                    }
                }
                else
                {
                    MessageBox.Show("Eksik veya Hatali Giris Yaptiniz");
                }



            }
            catch
            {
                MessageBox.Show("Eklenemedi");
            }
        }

        private void BtnUrunlerim_Click(object sender, EventArgs e)
        {
            if(frmUserProductView == null)
            {
                frmUserProductView = new FrmUserProductView();
                frmUserProductView.MdiParent = this.MdiParent;
                frmUserProductView.FormClosed += new FormClosedEventHandler(FrmUserProductView_FormClosed);
                frmUserProductView.StartPosition = FormStartPosition.Manual;
                frmUserProductView.Location = new System.Drawing.Point(400, 100);
                frmUserProductView.Show();
            }
            

        }

        private void FrmUserProductView_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUserProductView =null;
        }

        private void BtnBilesenAciklama_Click(object sender, EventArgs e)
        {
            try
            {
                var file = openFileDialog1.ShowDialog() == DialogResult.OK;
                if (file)
                {
                    string fileName = openFileDialog1.FileName;
                    string readFile = File.ReadAllText(fileName);
                    txtBilesenAciklama.Text = readFile;
                }
                else
                {
                    MessageBox.Show("Bir Text secmediniz");
                }
            }
            catch
            {
                MessageBox.Show("Herhangi bir text seçmediniz");
            }
        }

        private void BtnBilesen_Click(object sender, EventArgs e)
        {
            if(userBilesen == null)
            {
                userBilesen = new FrmUserBilesen(values);
                userBilesen.MdiParent = this.MdiParent;
                userBilesen.FormClosed += new FormClosedEventHandler(FrmUserBilesen_FormClosed);
                userBilesen.StartPosition = FormStartPosition.Manual;
                userBilesen.Location = new System.Drawing.Point(400, 100);
                userBilesen.Show();
            }
        }

        private void FrmUserBilesen_FormClosed(object sender, FormClosedEventArgs e)
        {
            userBilesen = null;
            lblBilesenSayisi.Text = values.Count.ToString();
        }

        private void BtnResim_Click(object sender, EventArgs e)
        {
            if (userResim == null)
            {
                userResim = new FrmUserResim(resimYollari);
                userResim.MdiParent = this.MdiParent;
                userResim.FormClosed += new FormClosedEventHandler(FrmUserResim_FormClosed);
                userResim.StartPosition = FormStartPosition.Manual;
                userResim.Location = new System.Drawing.Point(600, 100);
                userResim.Show();
            }
        }

        private void FrmUserResim_FormClosed(object sender, FormClosedEventArgs e)
        {
            userResim = null;
            lblResimSayisi.Text = resimYollari.Count.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
