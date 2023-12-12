using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminUrunVM
    {
        public Guid ID { get; set; }
       
        public string BarkodNumarasi { get; set; }
      
        public string UrunAdi { get; set; }

        public int? KategoriID { get; set; }

        public string UrunAciklamasi { get; set; }

        public bool? AktifMi { get; set; }
        public override string ToString()
        {
            return UrunAdi;
        }
    }
}
