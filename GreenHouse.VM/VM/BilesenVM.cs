using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class BilesenVM
    {
        public Guid ID { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public Guid? OlusturanKullaniciRolID { get; set; }
        public bool? AktifMi { get; set; }
        public int RiskID { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
