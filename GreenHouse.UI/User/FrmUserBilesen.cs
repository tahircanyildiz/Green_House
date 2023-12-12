using GreenHouse.BLL.UsersBLL;
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
    public partial class FrmUserBilesen : Form
    {
        List<Tuple<string, int, string>> bilesenler = new List<Tuple<string, int, string>>();
        public FrmUserBilesen()
        {
            InitializeComponent();
        }
        public FrmUserBilesen(List<Tuple<string, int, string>> _bilesenler) : this()
        {
            bilesenler = _bilesenler;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                bilesenler.Remove(listBox1.SelectedItem as Tuple<string, int, string>);
                MessageBox.Show("Bilesen silinmistir");
                listBox1.DataSource = null;
                listBox1.DataSource = bilesenler;
            }
            else
            {
                MessageBox.Show("Eksik veya hatali giris yaptiniz");
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && cmbBilesen.SelectedItem != null)
            {
                Tuple<string, int, string> tuple = new Tuple<string, int, string>(txtBilesen.Text, (cmbBilesen.SelectedItem as RiskVM).ID, txtBilesenAciklama.Text);

                bilesenler[bilesenler.IndexOf(listBox1.SelectedItem as Tuple<string, int, string>)] = tuple;
                MessageBox.Show("Bilesen güncellenmistir");
                listBox1.DataSource = null;
                listBox1.DataSource = bilesenler;
            }
            else
            {
                MessageBox.Show("Eksik veya hatali giris yaptiniz");
            }
        }

        private void FrmUserBilesen_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = bilesenler;
            cmbBilesen.Items.AddRange(new UserRiskBLL().TumRiskGetir().ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                txtBilesen.Text = (listBox1.SelectedItem as Tuple<string, int, string>).Item1.ToString();
                txtBilesenAciklama.Text = (listBox1.SelectedItem as Tuple<string, int, string>).Item3.ToString();
                cmbBilesen.SelectedItem = new UserRiskBLL().IDIleGetir((listBox1.SelectedItem as Tuple<string, int, string>).Item2);
            }
            
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
