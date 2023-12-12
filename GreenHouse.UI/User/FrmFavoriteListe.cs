using GreenHouse.BLL.UsersBLL;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.User;
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

namespace GreenHouse.UI.User
{
    public partial class FrmFavoriteListe : Form
    {
        public FrmFavoriteListe()
        {
            InitializeComponent();
        }
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        private void FrmFavoriteListe_Load(object sender, EventArgs e)
        {
            ListBoxDoldur();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtAd.Text))
            {
                MessageBox.Show("bir liste ismi giriniz.");
                return;
            }
            Guid ID = Guid.NewGuid();
            KullaniciListesiBLL kullaniciListesiBLL = new KullaniciListesiBLL();
            var gelen = kullaniciListesiBLL.KullaniciListesiOlustur(new VM.VM.KullaniciListesiVM() { ID= ID,ListeAdi=TxtAd.Text,UstID=ID,
            ListeTipiID=1,KullaniciRolID=gelenUser.Datas.KullaniciRoluID,AktifMi=true});
            if (gelen==null)
            {
                MessageBox.Show("İşlem Başarısız");
            }
            else
            {
                MessageBox.Show("Eklendi");
                ListBoxDoldur();
                Temizle();
            }
        }

        private void lstFavoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtAd.Text = (lstFavoriler.SelectedItem as KullaniciListesiVM).ListeAdi;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var secilenKullaniciListesi = (lstFavoriler.SelectedItem as KullaniciListesiVM);
            if (secilenKullaniciListesi == null)
            {
                MessageBox.Show("bir liste seçiniz");
                return;
            }
            KullaniciListesiBLL kullaniciListesiBLL = new KullaniciListesiBLL();
            var sonuc= kullaniciListesiBLL.KullaniciListesiSil(new KullaniciListesiVM() {ID=secilenKullaniciListesi.ID,ListeAdi=secilenKullaniciListesi.ListeAdi,KullaniciRolID=secilenKullaniciListesi.KullaniciRolID,ListeTipiID=secilenKullaniciListesi.ListeTipiID,AktifMi=secilenKullaniciListesi.AktifMi });
            if (sonuc.Datas==null)
            {
                MessageBox.Show(sonuc.Message);
            }
            else
            {
                MessageBox.Show(sonuc.Message);
                ListBoxDoldur();
                Temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var secilenKullaniciListesi = (lstFavoriler.SelectedItem as KullaniciListesiVM);
            if (secilenKullaniciListesi==null)
            {
                MessageBox.Show("lütfen bir liste seçiniz");
                return;
            }
            KullaniciListesiBLL kullaniciListesiBLL = new KullaniciListesiBLL();
            var sonuc = kullaniciListesiBLL.KullaniciListesiGuncelle(new KullaniciListesiVM() { ID=secilenKullaniciListesi.ID,ListeAdi=TxtAd.Text,ListeTipiID=secilenKullaniciListesi.ListeTipiID,KullaniciRolID=secilenKullaniciListesi.KullaniciRolID,AktifMi=true});

            if (sonuc.Datas==null)
            {
                MessageBox.Show(sonuc.Message);
            }
            else
            {
                MessageBox.Show(sonuc.Message);
                ListBoxDoldur();
                Temizle();
            }

        }

        public void ListBoxDoldur()
        {
            lstFavoriler.Items.Clear();
            KullaniciListesiBLL kullaniciListesiBLL = new KullaniciListesiBLL();
            lstFavoriler.Items.AddRange(kullaniciListesiBLL.ListeTipineGoreListeleriniGetir(gelenUser.Datas.ID, 1, true).ToArray());
        }

        private void Temizle()
        {
            TxtAd.Text = "";
        }
    }
}
