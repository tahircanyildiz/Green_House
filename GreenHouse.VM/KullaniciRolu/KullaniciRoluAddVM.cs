using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.KullaniciRolu
{
    public class KullaniciRoluAddVM
    {
        public Guid ID { get; set; }
        public Guid KullaniciID { get; set; }
        public int RolID { get; set; }
        public DateTime RoleAtandigiZaman { get; set; }
        public bool AktifMi { get; set; } 
        public DateTime OlusturlmaTarihi { get; set; }
    }
}
