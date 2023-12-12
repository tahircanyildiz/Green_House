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
    public partial class BlackList : Form
    {
        
        public BlackList()
        {
            InitializeComponent();
        }
        
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        private void BlackList_Load(object sender, EventArgs e)
        {
            ListboxDoldur();
            BlackListBoxUrunDoldur();
            BlackListBoxBilesenDoldur();
            

        }

        private void BtnEkleUrun_Click(object sender, EventArgs e)
        {

        }

        private void BtnSilUrun_Click(object sender, EventArgs e)
        {
            ListeIcerikBLL listeIcerikBLL = new ListeIcerikBLL();
            var silinecekUrun = lstBlackListProduct.SelectedItem as ListeIcerikVM;
            if (silinecekUrun == null)
            {
                MessageBox.Show("lütfen listenizden silmek istediğiniz ürünü seçin.");
                return;
            }
            var gelen = listeIcerikBLL.ListeIcerikSil(new ListeIcerikVM() { ID=silinecekUrun.ID,ListeID=silinecekUrun.ListeID,UrunMu=silinecekUrun.UrunMu,IcerikID=silinecekUrun.IcerikID});
            if (gelen.Datas==null)
            {
                MessageBox.Show(gelen.Message);
                return;
            }
            MessageBox.Show(gelen.Message);
            BlackListBoxUrunDoldur();


        }

    

        private void lstBlackListProduct_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lstBlackListProduct_DragDrop(object sender, DragEventArgs e)
        {
            
            
            ListeIcerikDAL listeIcerikDAL = new ListeIcerikDAL(gelenUser.Datas);
            Guid listeID = listeIcerikDAL.KaraListeIDGetir();
            Guid ID = Guid.NewGuid();
            if (listeID == Guid.Empty)
            {

                KullaniciListesiDAL kullaniciListesiDAL = new KullaniciListesiDAL();
                kullaniciListesiDAL.KullaniciListesiEkle(new KullaniciListesiVM() { ID = ID, ListeTipiID = 2, ListeAdi = "Kara Listem", UstID = ID, KullaniciRolID = gelenUser.Datas.KullaniciRoluID });
            }

            Guid oListeID = listeIcerikDAL.KaraListeIDGetir();

            var draggedData = e.Data.GetData(typeof(UrunVM)) as UrunVM;
            ListeIcerikBLL listeIcerikBLL = new ListeIcerikBLL();
            var gelenDeger = listeIcerikBLL.KaraListeIcerikEkle(new ListeIcerikVM() {
                ID=Guid.NewGuid(),
                ListeID= oListeID,
                UrunMu=true,
                IcerikID=draggedData.ID,
            });

            if (gelenDeger.Datas!=null)
            {
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show(gelenDeger.Message);
            }
            BlackListBoxUrunDoldur();

            //listBox1.Items.Add(draggedData);

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                listBox1.DoDragDrop(listBox1.SelectedItem as UrunVM, DragDropEffects.All);
            }
        }
        private void BlackListBoxUrunDoldur()
        {
            lstBlackListProduct.Items.Clear();
            // kullaniciRolID ile beraber urunler için blacklist getiriyor.
            var gelen = new ListeIcerikBLL().ListeIcerikGetir(gelenUser.Datas.KullaniciRoluID, 2);
            foreach (var item in gelen)
            {
                lstBlackListProduct.Items.Add(item);

            }
        }
        private void ListboxDoldur()
        {
            //hepsini getir
            listBox1.Items.AddRange(new UserUrunBLL().GetirBLL().ToArray());
            //hepsini getir
            listBox2.Items.AddRange(new BilesenBLL().TumBilesenGetirBLL().ToArray());
              
        }

        private void BlackListBoxBilesenDoldur()
        {

            lstBlackListIngredient.Items.Clear();

            lstBlackListIngredient.Items.AddRange( new ListeIcerikBLL().KaraListeBilesenGetir(gelenUser.Datas.KullaniciRoluID,2).Datas.ToArray());
            
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                listBox2.DoDragDrop(listBox2.SelectedItem as BilesenVM, DragDropEffects.All);
            }
        }

        private void lstBlackListIngredient_DragDrop(object sender, DragEventArgs e)
        {
            ListeIcerikDAL listeIcerikDAL = new ListeIcerikDAL(gelenUser.Datas);
            Guid listeID = listeIcerikDAL.KaraListeIDGetir();

            var draggedData = e.Data.GetData(typeof(BilesenVM)) as BilesenVM;
            ListeIcerikBLL listeIcerikBLL = new ListeIcerikBLL();
            var gelenDeger = listeIcerikBLL.KaraListeIcerikEkle(new ListeIcerikVM()
            {
                ID = Guid.NewGuid(),
                ListeID = listeID,
                UrunMu = false,
                IcerikID = draggedData.ID,
            });

            if (gelenDeger.Datas != null)
            {
                MessageBox.Show(" Bilesen Eklendi");
                BlackListBoxBilesenDoldur();
            }
            else
            {
                MessageBox.Show(gelenDeger.Message);
            }
            
        }
        private void lstBlackListIngredient_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnSilIcerik_Click(object sender, EventArgs e)
        {
            ListeIcerikBLL listeIcerikBLL = new ListeIcerikBLL();
            var silinecekUrun = lstBlackListIngredient.SelectedItem as ListeIcerikVM;
            if (silinecekUrun==null)
            {
                MessageBox.Show("listeden silinecek bir eleman seçiniz");
                return;
            }
            var gelen = listeIcerikBLL.ListeIcerikSil(new ListeIcerikVM() { ID = silinecekUrun.ID, ListeID = silinecekUrun.ListeID, UrunMu = silinecekUrun.UrunMu, IcerikID = silinecekUrun.IcerikID });
            if (gelen.Datas == null)
            {
                MessageBox.Show(gelen.Message);
                return;
            }
            MessageBox.Show(gelen.Message);
            BlackListBoxBilesenDoldur();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEkleIcerik_Click(object sender, EventArgs e)
        {

        }
    }
}
