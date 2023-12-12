using GreenHouse.BLL.AdminsBLL;
using GreenHouse.UI.User;
using GreenHouse.VM.AdminVMs;
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

namespace GreenHouse.UI.AdminPanel.UI
{
    public partial class AdminPanelUI : Form
    {
        AdminMenuElemanBLL _menuElemanBLL = new AdminMenuElemanBLL();
        AdminSayfaMenuBLL _sayfaMenu = new AdminSayfaMenuBLL();
        public AdminPanelUI()
        {
            InitializeComponent();
        }
        public GirisYapKullaniciVM _girisYapanKullanici;

        public AdminPanelUI(GirisYapKullaniciVM kullanici) : this()
        {
            _girisYapanKullanici = kullanici;
        }
        private void AdminPanelUI_Load(object sender, EventArgs e)
        {
            MenuleriOlustur();
            this.Size = new Size(MaximumSize.Width, MaximumSize.Height);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void MenuleriOlustur()
        {
            List<AdminMenuVM> menuler = _sayfaMenu.GetMenulerListWithSayfaAdi("AdminPanelUI").Datas;
            MenuStrip menuStrip = new MenuStrip();

            foreach (var menu in menuler)
            {
                ToolStripMenuItem stripMenuItem = new ToolStripMenuItem(menu.MenuAdi);
                List<AdminElemanVM> elemanlar = _menuElemanBLL.GetElemanListWithMenuID(menu).Datas;
                foreach (var menuItem in elemanlar)
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(menuItem.MenuElemanAdi);
                    toolStripMenuItem.Tag = menuItem;
                    
                    toolStripMenuItem.Click += ToolStripMenuItem_Click;
                    stripMenuItem.DropDownItems.Add(toolStripMenuItem);
                }
                menuStrip.Items.Add(stripMenuItem);
            }
            this.Controls.Add(menuStrip);
        }
        private void OpenOrActivateForm<T>() where T : Form, new()
        {
            // Açık olan formları kontrol et
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    // Form zaten açıksa, onu öne getir ve işlemi sonlandır
                    form.Activate();
                    return;
                }
            }

            // Form daha önce açılmamışsa, yeni bir örnek oluştur ve göster
            T newForm = new T();
            newForm.MdiParent = this;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = new Point(
                (this.ClientSize.Width - newForm.Width) / 2,
                (this.ClientSize.Height - newForm.Height) / 2
            );
            // veya farklı bir parent form belirleyin
            newForm.Show();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

           

            switch (sender.ToString())
            {
                case "User":
                    OpenOrActivateForm<AdminUserControlUI>();
                    break;
                case "Yetki":
                    OpenOrActivateForm<AdminYetkiUI>();
                    break;
                case "Urun":
                    OpenOrActivateForm<AdminUrunUI>();
                    break;
                case "UrunIcerik":
                    OpenOrActivateForm<AdminUrunIcerikUI>();
                    break;
                case "UrunFirma":
                    OpenOrActivateForm<AdminFirmaUrunUI>();
                    break;
                case "Resim":
                    OpenOrActivateForm<AdminResimUI>();
                    break;
                case "Firma":
                    OpenOrActivateForm<AdminFirmaUI>();
                    break;
                case "Menu":
                    OpenOrActivateForm<AdminMenuUI>(); 
                    break;
                case "Sayfa":
                    OpenOrActivateForm<AdminSayfaUI>();
                    break;
                case "Uygulama":
                    OpenOrActivateForm<AdminUygulamaUI>();
                    break;
                case "Kategori":
                    OpenOrActivateForm<AdminKategoriUI>();
                    break;
                case "Bilesen":
                    OpenOrActivateForm<AdminBilesenUI>();
                    break;
                case "Risk":
                    OpenOrActivateForm<AdminRiskUI>();
                    break;
                case "MenuEleman":
                    OpenOrActivateForm<AdminMenuElemanUI>();
                    break;
                case "UrunOnay":
                    OpenOrActivateForm<AdminUrunOnayUI>();
                    break;
                case "SayfaMenü":
                    OpenOrActivateForm<AdminSayfaMenuUI>();
                    break;
                case "CikisYap":
                    UserLogin userLogin = new UserLogin();
                    userLogin.Show();
                    this.Close();
                    break;

                default:
                    MessageBox.Show("Sayfa Ayarlarını kontrol ediniz.");
                    break;
            }

        }
       
    }
}
