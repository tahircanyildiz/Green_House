using GreenHouse.BLL.UsersBLL;
using GreenHouse.VM.VM;
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
    public partial class AdminUrunDetayUI : Form
    {
        private UrunVM gelenUrun;

        public AdminUrunDetayUI(UrunVM gelenUrun) : this()
        {
            this.gelenUrun = gelenUrun;
        }

        private int cokRisk;
        private int yüksekRisk;
        private int ortaRisk;
        private int düsükRisk;
        private int risksiz;
        public AdminUrunDetayUI()
        {
            InitializeComponent();
        }

        private void AdminUrunDetayUI_Load(object sender, EventArgs e)
        {
            foreach (var data in new UrunBilesenBLL().UrunBilesikGetirBLL(gelenUrun))
            {
                lstProductIngredients.Items.AddRange(new BilesenBLL().UrunBilesikGetirBLL(data).ToArray());
            }
            RiskeGöreTextDegis();
            lblKategori.Text = new KategoriBLL().IcerigeGöreKategoriGetirBLL(gelenUrun).KategoriAdi;
            lblUrun.Text = gelenUrun.UrunAdi;
            lblCokRiskli.Text = cokRisk.ToString();
            lblYüksekRiskli.Text = yüksekRisk.ToString();
            lblOrtaRiskli.Text = ortaRisk.ToString();
            lblAzRiskli.Text = düsükRisk.ToString();
            lblRisksiz.Text = risksiz.ToString();
        }
        private void lstProductIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            rchProductIngredientsDetails.Text = (lstProductIngredients.SelectedItem as BilesenVM).Aciklama;
        }
        private void RiskeGöreTextDegis()
        {
            foreach (var data in lstProductIngredients.Items.OfType<BilesenVM>())
            {
                switch (data.RiskID)
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
    }
}
