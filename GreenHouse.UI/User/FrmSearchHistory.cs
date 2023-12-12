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
    public partial class FrmSearchHistory : Form
    {
        public FrmSearchHistory()
        {
            InitializeComponent();
        }

        private void FrmSearchHistory_Load(object sender, EventArgs e)
        {
            lstSearchHistory.DataSource = new AramaGecmisiBLL().GetirAramaGecmisiBLL(Guid.Parse("96839c73-1738-4593-be90-627c12387c00"));
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(new AramaGecmisiBLL().SilAramaGecmisiBLL(lstSearchHistory.SelectedItem as AramaGecmisiVM))
            {
                MessageBox.Show("Deleted");
                lstSearchHistory.DataSource = new AramaGecmisiBLL().GetirAramaGecmisiBLL(Guid.Parse("96839c73-1738-4593-be90-627c12387c00"));
            }
            else
            {
                MessageBox.Show("Amogus");
            }
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            if(new AramaGecmisiBLL().SilTümAramaGecmisiBLL(lstSearchHistory.Items.Cast<AramaGecmisiVM>().ToList()))
            {
                MessageBox.Show("Deleted ALL");
                lstSearchHistory.DataSource = new AramaGecmisiBLL().GetirAramaGecmisiBLL(Guid.Parse("96839c73-1738-4593-be90-627c12387c00"));
            }
            else
            {
                MessageBox.Show("Amogus");
            }
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            FrmUser user = new FrmUser();

            user.Show();
        }

        private void BtnSideMenu_Click(object sender, EventArgs e)
        {
            FrmSideMenu side = new FrmSideMenu();
            side.Show();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu main = new FrmMainMenu();
            main.Show();
        }
    }
}
