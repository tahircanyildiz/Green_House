using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreenHouse.BLL.AdminsBLL;
using GreenHouse.BLL.UsersBLL;
using GreenHouse.VM.VM;
using Image = System.Drawing.Image;

namespace GreenHouse.UI.User
{
    public partial class ProductContent : Form
    {
        private UrunVM gelenUrun;
        private int cokRisk;
        private int yüksekRisk;
        private int ortaRisk;
        private int düsükRisk;
        private int risksiz;
        private int mevcutResimIndex = 0;
        public ProductContent()
        {
            InitializeComponent();
        }
        public ProductContent(UrunVM urunVM) : this()
        {
            gelenUrun = urunVM;
        }

        private void ProductContent_Load(object sender, EventArgs e)
        {
            foreach(var data in new UrunBilesenBLL().UrunBilesikGetirBLL(gelenUrun))
            {
                lstProductIngredients.Items.AddRange(new BilesenBLL().UrunBilesikGetirBLL(data).ToArray());
            }
            RiskeGöreTextDegis();
            lblKategori.Text = new KategoriBLL().IcerigeGöreKategoriGetirBLL(gelenUrun).KategoriAdi;
            ImageListeEkle();
            lblUrun.Text = gelenUrun.UrunAdi;
            lblCokRiskli.Text = cokRisk.ToString();
            lblYüksekRiskli.Text = yüksekRisk.ToString();
            lblOrtaRiskli.Text = ortaRisk.ToString();
            lblAzRiskli.Text = düsükRisk.ToString();
            lblRisksiz.Text = risksiz.ToString();
            TarafindanEklendi();
        }

        private void lstProductIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            rchProductIngredientsDetails.Text = (lstProductIngredients.SelectedItem as BilesenVM).Aciklama;
        }

        private void RiskeGöreTextDegis()
        {
            lstProductIngredients.DrawMode = DrawMode.OwnerDrawFixed;
            foreach(var data in lstProductIngredients.Items.OfType<BilesenVM>())
            {
                switch(data.RiskID)
                {
                    case 1:
                        
                        cokRisk++;
                        break;
                    case 2:
                        yüksekRisk++;
                        break;
                    case 3:
                        ortaRisk++;
                        break;
                    case 4:
                        düsükRisk++;
                        break;
                    case 5:
                        risksiz++;
                        break;
                }
            }

        }

        private void BtnSagIndex_Click(object sender, EventArgs e)
        {
            if(mevcutResimIndex < ımageList1.Images.Count - 1)
            {
                pbProduct.Image = ımageList1.Images[mevcutResimIndex + 1];
                mevcutResimIndex++;
            }
        }

        private void BtnSolIndex_Click(object sender, EventArgs e)
        {
            if(mevcutResimIndex != 0)
            {
                pbProduct.Image = ımageList1.Images[mevcutResimIndex - 1];
                mevcutResimIndex--;
            }
            
        }


        private void lstProductIngredients_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                BilesenVM data = lstProductIngredients.Items[e.Index] as BilesenVM;
                if (data != null)
                {
                    Color backgroundColor = Color.Black; // Varsayılan arka plan rengi (örnek olarak siyah)

                    switch (data.RiskID)
                    {
                        case 1:
                            backgroundColor = Color.Red;
                            break;
                        case 2:
                            backgroundColor = Color.IndianRed;
                            break;
                        case 3:
                            backgroundColor = Color.Orange;
                            break;
                        case 4:
                            backgroundColor = Color.Yellow;
                            break;
                        case 5:
                            backgroundColor = Color.Green;
                            break;
                    }

                    // Özel arka plan rengi ile öğeyi çizin
                    e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);
                    e.Graphics.DrawString(data.ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
                }
            }
        }

        private void ImageListeEkle()
        {
            try
            {
                List<Image> images = new List<Image>();

                foreach (var data in new ResimBLL().UruneGoreGetir(gelenUrun))
                {
                    Image image = Image.FromFile(data);
                    images.Add(image);
                }
                ımageList1.Images.AddRange(images.ToArray());
                pbProduct.Image = ımageList1.Images[0];
            }
            catch
            {

            }
            
        }

        private void TarafindanEklendi()
        {
            if(new KullaniciUIBLL().KullaniciGetir(gelenUrun.ID) != null)
            {
                rchAddedByCustomer.Text = "Bu urun " + new KullaniciUIBLL().KullaniciGetir(gelenUrun.ID).Adi + " adli kullanici tarafindan eklenmistir";
            }
            else
            {
                rchAddedByCustomer.Text = "Bu urunu ekleyen kullanici ismini beyan etmemektedir";
            }
        }
    }
}
