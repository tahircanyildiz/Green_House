using GreenHouse.BLL.UsersBLL;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.UI.UserUI;
using GreenHouse.VM.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.User
{
    public partial class FrmFavoriteList : Form
    {
        public FrmFavoriteList()
        {
            InitializeComponent();
        }
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;

        private void BtnAddFavoriteProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtListeAdi.Text))
            {
                MessageBox.Show("Liste ismi girmelisiniz");
                return;

            }
            KullaniciListesiBLL klBLL = new KullaniciListesiBLL();
            var gelenVeri = klBLL.KullaniciListesiOlustur(new VM.VM.KullaniciListesiVM() { ID = Guid.NewGuid(),ListeAdi=TxtListeAdi.Text,ListeTipiID= 1,AktifMi=true,KullaniciRolID= gelenUser.Datas.KullaniciRoluID}) ;

            if (gelenVeri.Datas!=null)
            {
                MessageBox.Show("Liste Başarıyla eklendi");
                Temizle();
                FrmFavorites frmFavorites = new FrmFavorites();
                frmFavorites.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(gelenVeri.Message);
            }

        }

        public void Temizle()
        {
            TxtListeAdi.Text = "";
        }

        private void FrmFavoriteList_Load(object sender, EventArgs e)
        {

        }
    }
}
