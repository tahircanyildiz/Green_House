using GreenHouse.BLL.User;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.UI.AdminPanel.UI;
using GreenHouse.UI.UserUI;
using GreenHouse.VM.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.User
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        public GeneralReturnType<GirisYapKullaniciVM> gelenUser;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();

            if (string.IsNullOrWhiteSpace(txtUserEmail.Text) || string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                MessageBox.Show("Lütfen tüm giriş alanlarını doldurun.");
                return;
            }

            gelenUser = userBLL.GirisYap(txtUserEmail.Text, txtUserPassword.Text);
            UserSingleton.Instance.GelenUser = gelenUser;

            if (gelenUser.Datas!=null)
            {
                if (gelenUser.Datas.KullaniciRolID==1)
                {
                    AdminPanelUI adminPanelUI = new AdminPanelUI(gelenUser.Datas);
                    adminPanelUI.Show();
                    this.Hide();
                }
                else if(gelenUser.Datas.KullaniciRolID == 5)
                {
                    
                    
                    FrmMdiContainer frmMdiContainer = new FrmMdiContainer(gelenUser.Datas);
                    frmMdiContainer.Show();
                   
                    this.Hide();

               
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Extensions.SifreFormatKontrol(txtPassword.Text)==false)
            {
                MessageBox.Show("Sifreniz en az 8 karakter olmalı. İçerisinde bir büyük harf ve özel karakter içermeli.");
                return;
            }
            if (SifreTekrariKontrol(txtPassword.Text,txtPasswordAgain.Text))
            {
                MessageBox.Show("Sifre Tekrarı Hatalı");
                return;
            }
            if (new UserBLL().DahaOnceKayitOlmusMu(TxtEmail.Text))
            {
                MessageBox.Show("Bu epostaya sahip bir kullanıcı zaten var");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Ad alanı boş geçilemez");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Şifre boş geçilemez");
                return;
            }
            if (Extensions.MailMi(TxtEmail.Text) == false)
            {
                MessageBox.Show("Girdiğiniz değer bir maile benzemiyor.");
                return;
            }
            if (Extensions.SayiVarmi(txtName.Text, txtSurname.Text) == true || Extensions.OzelKarakterVarMi(txtName.Text, txtSurname.Text) == true)
            {
                MessageBox.Show("Ad ve Soyad alanlarına rakam ve özel karakter  girilemez");
                return;
            }
            UserBLL userBLL = new UserBLL();
            var gelen = userBLL.Add(new VM.User.UserKayitVM() { Email = TxtEmail.Text, Name = txtName.Text, Surname = txtSurname.Text, Password = txtPassword.Text, ID = Guid.NewGuid(),AktifMi=true,EmailOnayliMi=true }) ;
            MessageBox.Show(gelen.Message);
            Temizle();
        }
        public bool IsNullOrEmpty(params string[] values)
        {
            foreach (string value in values)
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return true;
                }
            }
            return false;
        }
        private bool SifreTekrariKontrol(string password,string passwordAgain)
        {
            return password != passwordAgain;
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void Temizle()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtPasswordAgain.Text = "";
            txtSurname.Text = "";
            TxtEmail.Text = "";
        }

        private void btnPasswordReset_Click(object sender, EventArgs e)
        {
            FrmForgetPassword frm = new FrmForgetPassword();
            frm.Show();
        }
    }
}
