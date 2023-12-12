using GreenHouse.BLL;
using GreenHouse.BLL.UsersBLL;
using GreenHouse.Core.Common;
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

namespace GreenHouse.UI.User
{
    public partial class FrmBarcode : Form
    {
        
        public FrmBarcode()
        {
            InitializeComponent();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            var urun = new UserUrunBLL().BarkodaGoreUrunGetir(txtBarkod.Text);
            if (urun == null)
            {
                MessageBox.Show("Girdiginiz barkoda gore urun bulunamadi!!");
                
            }
            else if (txtBarkod.Text.ControlNullOrWhiteSpaceAndLength(40))
            {
                
                ProductContent productContent = new ProductContent(urun);
                productContent.MdiParent = this.MdiParent;
                productContent.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Barkod Giriniz");
            }
            //UrunVM urun = null;
            //List<UrunBilesenVM> urunBilesenVMs = null;



            //    urun = new UserUrunBLL().BarkodaGoreUrunGetir(txtBarkod.Text);
            //    urunBilesenVMs = new UrunBilesenBLL().UrunBilesikGetirBLL(urun);

            //    StringBuilder sb = new StringBuilder();
            //    sb.Append("Ürün Adı : " + urun.UrunAdi + "\n");
            //    List<BilesenVM> bilesenVMs = new List<BilesenVM>();
            //    if (urun != null && urunBilesenVMs != null)
            //    {
            //        foreach (var item in urunBilesenVMs)
            //        {
            //            bilesenVMs.AddRange(new BilesenBLL().UrunBilesikGetirBLL(item));
            //        }
            //        sb.Append("Bileşenleri :" + "\n");
            //        bilesenVMs.ForEach(a => sb.Append(a.Adi + "\n"));
            //        MessageBox.Show(sb.ToString());
            //    }
            //    else
            //    {
            //        MessageBox.Show("Urun Bulunamadı");
            //    }


        }


        private void BtnFill_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string fileName = openFileDialog1.FileName;
                string readFile = File.ReadAllText(fileName);
                txtBarkod.Text = readFile;
            }
            catch
            {
                MessageBox.Show("Herhangi bir text seçmediniz");
            }
        }

        private void FrmBarcode_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
