using GreenHouse.BLL.AdminsBLL;
using GreenHouse.Core.Common;
using GreenHouse.VM.AdminVMs;
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
    public partial class AdminSayfaYetkiRolUI : Form
    {
        AdminRolBLL _rolBLL = new AdminRolBLL();
        AdminSayfaBLL _sayfaBLL = new AdminSayfaBLL();
        AdminYetkiBLL _yetkiBLL = new AdminYetkiBLL();
        AdminSayfaYetkiRolBLL _sayfaYetkiRolBLL = new AdminSayfaYetkiRolBLL();
        public AdminSayfaYetkiRolUI()
        {
            InitializeComponent();
        }

        private void AdminSayfaYetkiRolUI_Load(object sender, EventArgs e)
        {
            cmbSayfalar.DataSource = _sayfaBLL.GetAll().Datas;
            cmbYetkiler.DataSource = _yetkiBLL.GetAll().Datas;
            Temizle();
            RolleriListele();
        }

        private void btnRolEkle_Click(object sender, EventArgs e)
        {
            GeneralReturnType<AdminRolVM> generalReturnType = _rolBLL.Add(new AdminRolVM()
            {
                RolAdi = txtRolAdi.Text,
                AktifMi = chRolAktifMi.Checked
            });
            if (generalReturnType.StatusCode!=200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message+": Rol Eklendi.");
            RolleriListele();
            Temizle();
            
        }

        private void Temizle()
        {
            txtRolAdi.Text = string.Empty;
            chRolAktifMi.Checked =chSilinenRolleriGoster.Checked= false;
            cmbSayfalar.SelectedItem = cmbYetkiler.SelectedItem = null;
            
        }

        private void btnRolGuncelle_Click(object sender, EventArgs e)
        {
            if (lstRol.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Seçim Yapınız.");
                return;
            }
            GeneralReturnType<AdminRolVM> generalReturnType = _rolBLL.Update(new AdminRolVM()
            {
                ID=(lstRol.SelectedItem as AdminRolVM).ID,
                RolAdi = txtRolAdi.Text,
                AktifMi = chRolAktifMi.Checked
            });
            if (generalReturnType.StatusCode != 200)
            {
                MessageBox.Show(generalReturnType.Message);
                return;
            }
            MessageBox.Show(generalReturnType.Message + ": Rol Guncellendi.");
            RolleriListele();
            Temizle();
        }

        private void chSilinenRolleriGoster_CheckedChanged(object sender, EventArgs e)
        {
            RolleriListele();
        }

        private void RolleriListele()
        {
            lstRol.Items.Clear();

            if (chSilinenRolleriGoster.Checked)
            {
                lstRol.Items.AddRange(_rolBLL.GetAll().Datas.ToArray());
                return;
            }
            lstRol.Items.AddRange(_rolBLL.GetAllWithoutDeleted().Datas.ToArray());
        }

        private void rolSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstRol.SelectedItem == null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
                return;
            }
            DialogResult dg = MessageBox.Show("silmek istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                GeneralReturnType<AdminRolVM> generalReturnType = _rolBLL.Delete(lstRol.SelectedItem as AdminRolVM);
                if (generalReturnType.StatusCode != 200)
                {
                    MessageBox.Show(generalReturnType.Message);
                    return;
                }
                MessageBox.Show(generalReturnType.Message + ": Rol Silindi.");
                Temizle();
                RolleriListele();
            }
        }

        private void lstRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRol.SelectedItem == null)
            {
                return;
            }
            txtRolAdi.Text = (lstRol.SelectedItem as AdminRolVM).RolAdi;
        }

        private void cmbSayfalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSayfalar.SelectedItem == null)
            {
                return;
            }
            SayfaRolleriListele();
        }

        private void SayfaRolleriListele()
        {
            lstSYRoller.Items.Clear();
            lstSYRoller.Items.AddRange(_sayfaYetkiRolBLL.GetRollerListWithSayfaID(cmbSayfalar.SelectedItem as AdminSayfaVM).Datas.ToArray());
        }

        private void lstSYRoller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSayfalar.SelectedItem == null||lstSYRoller.SelectedItem==null)
            {
                return;
            }
            chlsYetkiler.Items.Clear();
            chlsYetkiler.Items.AddRange(_sayfaYetkiRolBLL.GetYetkilerWithSayfaRolID(cmbSayfalar.SelectedItem as AdminSayfaVM, lstSYRoller.SelectedItem as AdminRolVM).Datas.ToArray());
        }
        //todo burada kaldın.
    }
}
