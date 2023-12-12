using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class UrunVM
    {
        public Guid ID { get; set; }
        public string BarkodNumarasi { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAciklamasi { get; set; }
        public int KategoriID { get; set; }
        public bool? AktifMi { get; set; }
        public Guid? OlusturanKullaniciRolID { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public override string ToString()
        {
            return UrunAdi;
        }
    }
}
