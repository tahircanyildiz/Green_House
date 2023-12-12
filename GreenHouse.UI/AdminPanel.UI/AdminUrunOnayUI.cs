using GreenHouse.BLL.AdminsBLL;
using GreenHouse.BLL.UsersBLL;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.UI.User;
using GreenHouse.VM.AdminVMs;
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

namespace GreenHouse.UI.AdminPanel.UI
{
    public partial class AdminUrunOnayUI : Form
    {
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        AdminUrunOnayBLL adminUrunOnayBLL = new AdminUrunOnayBLL();



        public AdminUrunOnayUI()
        {
            InitializeComponent();
        }

        private void AdminUrunOnayUI_Load(object sender, EventArgs e)
        {

            
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Listele();
        }

        private void Listele()
        {
            int i = 1;
            lstUrunler.Items.Clear();
            List<AdminUrunOnayVM> list = adminUrunOnayBLL.GetAll().Datas;
            if (chIncelenenleriGoster.Checked)
            {
                if (list==null)
                {
                    return;
                }
                foreach (var item in list)
                {

                    string[] row = { i.ToString(), item.UrunAdi, item.TakipNumarasi, item.KullaniciGozukmeDurumu.ToString(), item.EkleyenKullaniciMail, item.InceleyenKullaniciMail, item.OnayDurumu.ToString(), item.IncelemeZamani.ToString(), item.ID.ToString() };
                    ListViewItem satir = new ListViewItem(row);
                    lstUrunler.Items.Add(satir);
                    i++;
                }
                return;
            }
            foreach (var item in list.Where(x => x.OnayDurumu == null))
            {
                string[] row = { i.ToString(), item.UrunAdi, item.TakipNumarasi, item.KullaniciGozukmeDurumu.ToString(), item.EkleyenKullaniciMail, item.InceleyenKullaniciMail, item.OnayDurumu.ToString(), item.IncelemeZamani.ToString(), item.ID.ToString() };
                ListViewItem satir = new ListViewItem(row);
                lstUrunler.Items.Add(satir);
                i++;
            }


        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int i = 1;
            List<AdminUrunOnayVM> list = adminUrunOnayBLL.GetAllWithTakipNo(txtTakipNo.Text).Datas;
            lstUrunler.Items.Clear();
            if (chIncelenenleriGoster.Checked)
            {
                foreach (var item in list)
                {
                    string[] row = { i.ToString(), item.UrunAdi, item.TakipNumarasi, item.KullaniciGozukmeDurumu.ToString(), item.EkleyenKullaniciMail, item.InceleyenKullaniciMail, item.OnayDurumu.ToString(), item.IncelemeZamani.ToString(), item.ID.ToString() };
                    ListViewItem satir = new ListViewItem(row);
                    lstUrunler.Items.Add(satir);
                    i++;
                }
                return;
            }
            foreach (var item in list.Where(x => x.OnayDurumu == null))
            {

                string[] row = { i.ToString(), item.UrunAdi, item.TakipNumarasi, item.KullaniciGozukmeDurumu.ToString(), item.EkleyenKullaniciMail, item.InceleyenKullaniciMail, item.OnayDurumu.ToString(), item.IncelemeZamani.ToString(), item.ID.ToString() };
                ListViewItem satir = new ListViewItem(row);
                lstUrunler.Items.Add(satir);
                i++;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void chIncelenenleriGoster_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItems.Count > 0)
            {
                AdminUrunVM secilenUrun = adminUrunOnayBLL.GetUrunWithName(lstUrunler.SelectedItems[0].SubItems[1].Text).Datas;
                txtUrunID.Text = secilenUrun.ID.ToString();
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            bool control = false;
            if (lstUrunler.SelectedItems.Count > 0)
            {
                control = adminUrunOnayBLL.Update(new AdminUrunOnayVM()
                {
                    UrunAdi = lstUrunler.SelectedItems[0].SubItems[1].Text,
                    TakipNumarasi = lstUrunler.SelectedItems[0].SubItems[2].Text,
                    KullaniciGozukmeDurumu = bool.Parse(lstUrunler.SelectedItems[0].SubItems[3].Text),
                    EkleyenKullaniciMail = lstUrunler.SelectedItems[0].SubItems[4].Text,
                    InceleyenKullaniciMail = gelenUser.Datas.Email,//gelen userdatadan mailini ver.
                    OnayDurumu = true,
                    IncelemeZamani = DateTime.Now,
                    ID = Guid.Parse(lstUrunler.SelectedItems[0].SubItems[8].Text)
                });
            }
            if (!control)
            {
                MessageBox.Show("Onaylanamadı.");
                return;
            }
            MessageBox.Show("Urun Onaylandı.");
            Listele();
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            bool control = false;
            if (lstUrunler.SelectedItems.Count > 0)
            {
                control = adminUrunOnayBLL.Update(new AdminUrunOnayVM()
                {
                    UrunAdi = lstUrunler.SelectedItems[0].SubItems[1].Text,
                    TakipNumarasi = lstUrunler.SelectedItems[0].SubItems[2].Text,
                    KullaniciGozukmeDurumu = bool.Parse(lstUrunler.SelectedItems[0].SubItems[3].Text),
                    EkleyenKullaniciMail = lstUrunler.SelectedItems[0].SubItems[4].Text,
                    InceleyenKullaniciMail = gelenUser.Datas.Email,//gelen userdatadan mailini ver.
                    OnayDurumu = false,
                    IncelemeZamani = DateTime.Now,
                    ID = Guid.Parse(lstUrunler.SelectedItems[0].SubItems[8].Text)
                });
            }
            if (!control)
            {
                MessageBox.Show("Reddedilemedi.");
                return;
            }
            MessageBox.Show("Urun Reddedildi.");
            Listele();
        }

        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            //todo muratla bak.
            //AdminUrunDetayUI adminUrunDetayUI = new AdminUrunDetayUI(new UserUrunBLL().IDIleGetirBLL(Guid.Parse(txtUrunID.Text)));
            //adminUrunDetayUI.MdiParent = this.MdiParent;
            //adminUrunDetayUI.Show();

            ProductContent productContent = new ProductContent(new UserUrunBLL().IDIleGetirBLL(Guid.Parse(txtUrunID.Text))) ;
            productContent.MdiParent = this.MdiParent;
            productContent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
