using GreenHouse.BLL.UsersBLL;
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
    public partial class FrmUserProductView : Form
    {
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        public FrmUserProductView()
        {
            InitializeComponent();
        }

        private void FrmUserProductView_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void FillListView()
        {
            listView1.Items.Clear();
            string[] data = new string[5];
            int i = 0;
            new UrunOnayBLL().KullaniciUrunGetirBLL(gelenUser.Datas.ID).ForEach(x =>
            {
                ++i;
                data[0] = i.ToString();
                data[1] = x.Urun.UrunAdi;
                data[2] = (x.OnayDurumu.HasValue) ? (x.OnayDurumu.Value ? "Olumlu" : "Olumsuz") : "Beklemede";
                data[3] = x.Urun.OlusturulmaTarihi.ToString();
                data[4] = x.TakipNumarasi;
                listView1.Items.Add(new ListViewItem(data));
            });
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
