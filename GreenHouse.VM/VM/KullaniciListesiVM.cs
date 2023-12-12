using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class KullaniciListesiVM
    {
        public Guid ID { get; set; }
        public string ListeAdi { get; set; }
        public Guid UstID { get; set; }
        public Guid KullaniciRolID { get; set; }
        public int ListeTipiID { get; set; }
        public bool AktifMi { get; set; }

        public override string ToString()
        {
            return ListeAdi;
        }

    }
}
