using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminUrunFirmaVM
    {
        public Guid UrunID { get; set; }
        public Guid FirmaID { get; set; }
        public bool? AktifMi { get; set; }
    }
}
