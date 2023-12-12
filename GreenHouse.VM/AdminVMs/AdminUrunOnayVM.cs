using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminUrunOnayVM
    {
        public Guid ID { get; set; }
        
        public string TakipNumarasi { get; set; }

        public string UrunAdi { get; set; }

        public bool KullaniciGozukmeDurumu { get; set; }

        public string EkleyenKullaniciMail { get; set; }

        public string InceleyenKullaniciMail { get; set; }

        public bool? OnayDurumu { get; set; }

        public DateTime? IncelemeZamani { get; set; }
    }
}
