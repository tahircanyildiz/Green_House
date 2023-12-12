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
    public partial class UserPasswordReset : Form
    {
        
        GirisYapKullaniciVM _girisYapanKullaniciVM;
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        public UserPasswordReset()
        {
            InitializeComponent();
        }
        public UserPasswordReset(GirisYapKullaniciVM kullaniciBilgileri) :this()
        {
            _girisYapanKullaniciVM = kullaniciBilgileri;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNewPassword.Text) || String.IsNullOrWhiteSpace(txtOldPasssword.Text) || String.IsNullOrWhiteSpace(txtnewPasswordAgain.Text))
            {
                MessageBox.Show("Alanlar boş geçilemez");
                return;
            }
            if (SifreTekrariKontrolu(txtNewPassword.Text, txtnewPasswordAgain.Text) == false)
            {
                MessageBox.Show("Sifre ve Sifre Tekrarı aynı değil");
                return;
            }
            if (Extensions.SifreFormatKontrol(txtNewPassword.Text)==null)
            {
                MessageBox.Show("Sifreniz en az 8 karakter olmalı. İçerisinde bir büyük harf ve özel karakter içermeli.");
                return;
            }
            if (txtOldPasssword.Text!=gelenUser.Datas.Password)
            {
                MessageBox.Show("Eski şifre hatalı");
                return;
            }
            UserBLL userBLL = new UserBLL();
            
            var gelen = userBLL.PasswordReset(new PasswordResetVM() { ID = gelenUser.Datas.ID ,OldPassword=txtOldPasssword.Text,NewPassword=txtNewPassword.Text});
            if (gelen.Datas==null)
            {
                MessageBox.Show(gelen.Message);
                return;
            }
            MessageBox.Show(gelen.Message);
            Temizle();
        }
        private bool SifreTekrariKontrolu(string sifre, string sifreTekrar)
        {
            return sifre == sifre;
        }

        private void UserPasswordReset_Load(object sender, EventArgs e)
        {
        }
        public void Temizle()
        {
            txtNewPassword.Text="";
            txtnewPasswordAgain.Text = "";
            txtOldPasssword.Text = "";
        }
    }
}
