using GreenHouse.BLL.AdminsBLL;
using GreenHouse.Core.Common;
using GreenHouse.VM.AdminVMs;
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

namespace GreenHouse.UI.AdminPanel.UI
{
    public partial class AdminUserControlUI : Form
    {
        AdminKullaniciBLL kullaniciBLL;
        
        public AdminUserControlUI()
        {
            InitializeComponent();
            kullaniciBLL = new AdminKullaniciBLL();
        }
        private void KullanicilariListele()
        {
            lstUsers.Items.Clear();
            if (chSilinenUserleriGoster.Checked)
            {
                lstUsers.Items.AddRange(kullaniciBLL.GetAllUserList().Datas.ToArray());
                return;
            }
            lstUsers.Items.AddRange(kullaniciBLL.GetUserList().Datas.ToArray());
        }

        private void Temizle()
        {
            txtID.Text = txtAdi.Text = txtSoyadi.Text = txtEmail.Text = string.Empty;

        }
       


        private void AdminUserControlUI_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            KullanicilariListele();        
        }


        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKullaniciVM adminKullaniciVM = lstUsers.SelectedItem as AdminKullaniciVM;
            if (adminKullaniciVM == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminKullaniciVM> generalReturnType = kullaniciBLL.HardDelete(adminKullaniciVM);
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message);
                Temizle();
                KullanicilariListele();
                

            }
        }

        private void btnUserGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItem == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            AdminKullaniciVM guncellenecekKullanici = new AdminKullaniciVM()
            {
                ID = Guid.Parse(txtID.Text),
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Email = txtEmail.Text,
                PasswordHash = (lstUsers.SelectedItem as AdminKullaniciVM).PasswordHash,
                OlusturulmaTarihi = (lstUsers.SelectedItem as AdminKullaniciVM).OlusturulmaTarihi,
                EmailOnayliMi = (lstUsers.SelectedItem as AdminKullaniciVM).EmailOnayliMi,
                AktifMi = chUserAktifMi.Checked
            };
            GeneralReturnType<AdminKullaniciVM> generalReturnType = kullaniciBLL.Update(guncellenecekKullanici);
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                Temizle();
                KullanicilariListele();
                return;
            }
            MessageBox.Show(generalReturnType.Message);
            Temizle();
            KullanicilariListele();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminKullaniciVM secilenKullanici = lstUsers.SelectedItem as AdminKullaniciVM;
            if (secilenKullanici == null)
            {
                return;
            }
            txtAdi.Text = secilenKullanici.Adi;
            txtSoyadi.Text = secilenKullanici.Soyadi;
            txtEmail.Text = secilenKullanici.Email;
            chUserAktifMi.Checked = (bool)secilenKullanici.AktifMi;
            txtID.Text = secilenKullanici.ID.ToString();
        }

        private void btnUserAra_Click(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();
            lstUsers.Items.AddRange(kullaniciBLL.GetKullaniciWithMail(txtEmail.Text).Datas.ToArray());
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            KullanicilariListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
