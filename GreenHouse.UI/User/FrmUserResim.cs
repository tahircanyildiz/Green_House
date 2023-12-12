
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
    public partial class FrmUserResim : Form
    {
        private List<string> resimYollari = new List<string>();
        private string onYuzResimYolu;
        public FrmUserResim()
        {
            InitializeComponent();
        }
        public FrmUserResim(List<string> _resimYollari) : this()
        {
            resimYollari = _resimYollari;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUserResim_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = resimYollari;
            lblResimSayisi.Text = resimYollari.Count.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                resimYollari.Remove(listBox1.SelectedItem as string);
                MessageBox.Show("Resim silinmistir");
                listBox1.DataSource = null;
                listBox1.DataSource = resimYollari;
                lblResimSayisi.Text = resimYollari.Count.ToString();
            }
            else
            {
                MessageBox.Show("Eksik veya hatali giris yaptiniz");
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
           if(listBox1.SelectedItem != null && onYuzResimYolu != null)
           {
                resimYollari[resimYollari.IndexOf(listBox1.SelectedItem as string)] = onYuzResimYolu;
                MessageBox.Show("Resim güncellendi");
                listBox1.DataSource = null;
                listBox1.DataSource = resimYollari;
                lblResimSayisi.Text = resimYollari.Count.ToString();
                txtResimYol.Text = null;
           }
           else
           {
                MessageBox.Show("Resim secmediniz veya eksik giris yaptiniz");
           }
        }

        private void BtnFrontProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var file = openFileDialog1.ShowDialog() == DialogResult.OK;
                
                if (resimYollari.Count < 5 && file == true)
                {
                    onYuzResimYolu = null;
                    onYuzResimYolu = openFileDialog1.FileName;
                    lblResimSayisi.Text = resimYollari.Count.ToString();
                    txtResimYol.Text = onYuzResimYolu;
                }
                else if (file != true)
                {
                    MessageBox.Show("Resim secmediniz");
                }
                else
                {
                    MessageBox.Show("5 resimden fazla secemezsiniz");
                }

            }
            catch
            {

                MessageBox.Show("Herhangi bir resim seçmediniz");
            }
        }
    }
}
