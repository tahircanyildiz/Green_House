using EfDeneme.DAL.Concrete;
using GreenHouse.BLL.UsersBLL;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.UI.User;
using GreenHouse.VM.User;
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

namespace GreenHouse.UI.UserUI
{
    public partial class FrmFavorites : Form
    {
        public FrmFavorites()
        {
            InitializeComponent();
        }
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        private void BtnAddFavoriteProduct_Click(object sender, EventArgs e)
        {
            
            if (cmbFavoriListesi.SelectedItem==null)
            {
                MessageBox.Show("Favori Listesi Seçiniz");
                return;
            }
            if (cmbUrun.SelectedItem==null)
            {
                MessageBox.Show("Urun seçiniz");
                return;
            }
            ListeIcerikBLL listeIcerikBLL = new ListeIcerikBLL();
            var sonuc = listeIcerikBLL.FavoriListesineIcerikEkle(new VM.VM.ListeIcerikVM() { ID=Guid.NewGuid(),ListeID=(cmbFavoriListesi.SelectedItem as KullaniciListesiVM).ID,UrunMu=true,IcerikID=(cmbUrun.SelectedItem as UrunVM).ID  });

            if (sonuc.Datas!=null)
            {
                MessageBox.Show(sonuc.Message);
                cmbUrun.SelectedIndex = -1;
                cmbFavoriListesi.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(sonuc.Message);
            }
        }

        private void BtnDeleteFavoriteProduct_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddFavoriteContent_Click(object sender, EventArgs e)
        {
            

            if (CmbFavori.SelectedItem == null)
            {
                MessageBox.Show("Favori Listesi Seçiniz");
                return;
            }
            if (cmbIcerik.SelectedItem == null)
            {
                MessageBox.Show("Urun seçiniz");
                return;
            }
            ListeIcerikBLL listeIcerikBLL = new ListeIcerikBLL();
            var gelenVeri = listeIcerikBLL.FavoriListesineIcerikEkle(new ListeIcerikVM() { ID=Guid.NewGuid(),ListeID=(CmbFavori.SelectedItem as KullaniciListesiVM).ID,UrunMu=false,IcerikID=(cmbIcerik.SelectedItem as BilesenVM).ID });
            if (gelenVeri.Datas != null)
            {
                MessageBox.Show(gelenVeri.Message);
                cmbIcerik.SelectedIndex = -1;
                CmbFavori.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show(gelenVeri.Message);
            }
        }

        private void BtnDeleteFavoriteContent_Click(object sender, EventArgs e)
        {

        }

        private void lstFavoriteProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstFavoriteContent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmFavorites_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
            
        }
        public void ComboboxDoldur()
        {
            cmbUrun.Items.AddRange(new UserUrunBLL().GetirBLL().ToArray());
            cmbIcerik.Items.AddRange(new BilesenBLL().TumBilesenGetirBLL().ToArray());
            cmbFavoriListesi.Items.AddRange(new KullaniciListesiBLL().ListeTipineGoreListeleriniGetir(gelenUser.Datas.ID, 1,true).ToArray());
            CmbFavori.Items.AddRange(new KullaniciListesiBLL().ListeTipineGoreListeleriniGetir(gelenUser.Datas.ID, 1,true).ToArray());
            cmbFavoriFiltrele.Items.AddRange(new KullaniciListesiBLL().ListeTipineGoreListeleriniGetir(gelenUser.Datas.ID, 1,true).ToArray());
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

        private void BtnYeniFavoriListesi_Click(object sender, EventArgs e)
        {
            this.Close();
            //FrmFavoriteList frmFavoriteList = new FrmFavoriteList();
            //frmFavoriteList.Show();
            FrmFavoriteListe frmFavoriteListe = new FrmFavoriteListe();
            frmFavoriteListe.Show();
        }

        private void cmbFavoriFiltrele_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           var deger = (cmbFavoriFiltrele.SelectedItem as KullaniciListesiVM).ID;
            //ListeIcerikDAL listeIcerikDAL = new ListeIcerikDAL();
            //var gelen = listeIcerikDAL.FavoriListeGoreVeriGetir(deger);
            ListeIcerikBLL listeIcerikBLL = new ListeIcerikBLL();
            var gelen = listeIcerikBLL.FavoriListeGoreVeriGetir(deger);
            //listBox1.Items.AddRange(gelen.ToArray());
            if (gelen.Datas!=null)
            {
                listBox1.Items.AddRange(gelen.Datas.ToArray()); ;
            }
            else
            {
                MessageBox.Show(gelen.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var secilen = listBox1.SelectedItem as ListeIcerikVM;
            if (secilen == null)
            {
                MessageBox.Show("lütfen listeden silmek istediğiniz ögeyi seçin");
                return;
            }
            ListeIcerikBLL listeIcerikBLL = new ListeIcerikBLL();
            var sonuc = listeIcerikBLL.ListeIcerikSil(new ListeIcerikVM() { ID=secilen.ID,ListeID=secilen.ListeID,UrunMu=secilen.UrunMu,IcerikID=secilen.IcerikID});
            if (sonuc!=null)
            {
                MessageBox.Show(sonuc.Message);
                ListBoxTemizle();
                listBox1.Items.AddRange(listeIcerikBLL.FavoriListeGoreVeriGetir(sonuc.Datas.ListeID).Datas.ToArray());
            }
            else
            {
                MessageBox.Show(sonuc.Message);
            }
        }
        public void ListBoxTemizle()
        {
            listBox1.Items.Clear();
        }
    }
}
