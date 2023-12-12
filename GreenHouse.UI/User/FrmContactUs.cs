using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.User
{
    public partial class FrmContactUs : Form
    {
        public FrmContactUs()
        {
            InitializeComponent();
        }
       

        private void BtnGönder_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MailMessage mm = new MailMessage())
                {
                    mm.From = new MailAddress("groonhauss@hotmail.com");
                    mm.To.Add("fatih_elmas_44@windowslive.com");
                    mm.Subject = txtKonu.Text;
                    mm.Body = txtMesaj.Text;

                    using (SmtpClient sc = new SmtpClient("smtp.office365.com"))
                    {
                        sc.Port = 587;
                        sc.UseDefaultCredentials = false;
                        sc.Credentials = new System.Net.NetworkCredential("groonhauss@hotmail.com", "p123456789_");
                        sc.EnableSsl = true;
                        sc.Send(mm);
                    }
                }



                MessageBox.Show("Mesajiniz Alinmistir");
            }
            catch
            {
                MessageBox.Show("Hatali giris");
            }
        }
    }
}
