using GreenHouse.BLL.AdminsBLL;
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

namespace GreenHouse.UI.UserUI
{
    public partial class FrmPremium : Form
    {
        List<KullaniciPremiumTipVM> premium = new List<KullaniciPremiumTipVM>();
        public FrmPremium()
        {
            InitializeComponent();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            if(chcListBoxPremium.CheckedItems.Count == 1)
            {
                var selectedList = chcListBoxPremium.CheckedItems.Cast<KullaniciPremiumTipVM>().ToList();
                var selected = selectedList[0];
                premium.Add(selected);
                MessageBox.Show("Tebrikler artık "+ selected + " üyesiniz");
            }
            else
            {
                MessageBox.Show("Sadece bir üyelik tipi seçebilirsiniz");
            }
        }

        private void FrmPremium_Load(object sender, EventArgs e)
        {
            chcListBoxPremium.Items.AddRange(new KullaniciPremiumTipBLL().GetKullaniciPremiumTipBLL().ToArray());
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {

        }

        private void BtnSideMenu_Click(object sender, EventArgs e)
        {

        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
