using GreenHouse.BLL.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace GreenHouse.UI.User
{
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bu emailda bir kullanıcı var mı? 
            UserBLL userBLL = new UserBLL();
            var kullaniciVarMi= userBLL.DahaOnceKayitOlmusMu(txtEmail.Text);
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Bir email giriniz.");
                return;
            }
            if (kullaniciVarMi==false)
            {
                MessageBox.Show("Bu mail'e kayıtlı bir kullanıcı yok.");
                return;
            }
            else
            {
                var kullanici = userBLL.EmailaGoreKullaniciGetir(txtEmail.Text);
                string yeniSifre = userBLL.RandomSifreOlustur();
                using (TransactionScope tran = new TransactionScope())
                {
                    try
                    {
                        userBLL.KullaniciMailGonder(txtEmail.Text,"Yeni Şifre","Yeni şifreniz:"+ yeniSifre);
                        var sonuc = userBLL.Update(new VM.VM.KullaniciSelectVM() { ID=kullanici.Datas.ID,Adi=kullanici.Datas.Adi,Email=kullanici.Datas.Email,Soyadi=kullanici.Datas.Soyadi,AktifMi=kullanici.Datas.AktifMi,EmailOnaylandiMi=kullanici.Datas.EmailOnaylandiMi,PasswordHash=yeniSifre });
                        if (sonuc.Datas==null)
                        {
                            MessageBox.Show(sonuc.Message);
                            tran.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Şifre guncellendi. Giriş Yapabilirsiniz.");
                            tran.Complete();
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                        tran.Dispose();
                        throw;
                    }
                }

            }



        }
    }
}
