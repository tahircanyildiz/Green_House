using GreenHouse.BLL.User;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicsDAL;
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
    public partial class UserEmailReset : Form
    {
        //GIRISYAPKULLANICIVM DAHA KAPSAMLI OLUP BURADA VE PASSWORD RESETTE KULLANABILIRIM
        GirisYapKullaniciVM _girisYapmisKullaniciBilgileri;
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        public UserEmailReset()
        {
            InitializeComponent();
        }
        public UserEmailReset(GirisYapKullaniciVM kullaniciBilgileri) :this()
        {
            _girisYapmisKullaniciBilgileri = kullaniciBilgileri;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewEmail.Text)||string.IsNullOrWhiteSpace(txtOldEmail.Text)||String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Eksik veri girildi");
                return;
            }
            if (Extensions.MailMi(txtNewEmail.Text)==false)
            {
                MessageBox.Show("Doğru bir mail adresi giriniz.");
                return;
            }
            if (txtPassword.Text!=gelenUser.Datas.Password)
            {
                MessageBox.Show("Kullanici şifresi yanlış");
                return;
            }
            UserBLL userBLL = new UserBLL();
            var gelen = userBLL.EmailReset(new VM.User.EmailResetVM() { ID= gelenUser.Datas.ID,Password=txtPassword.Text,OldEmail=txtOldEmail.Text,NewEmail=txtNewEmail.Text });
            if (gelen==null)
            {
                MessageBox.Show(gelen.Message);
                return;
            }
            else
            {
                MessageBox.Show(gelen.Message);
                Temizle();
            }
            
            
        }

        private void gbPasswordReset_Enter(object sender, EventArgs e)
        {

        }
        public void Temizle()
        {
            txtNewEmail.Text = "";
            txtOldEmail.Text = "";
            txtPassword.Text = "";
        }
    }
}
