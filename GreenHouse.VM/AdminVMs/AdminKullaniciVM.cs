using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminKullaniciVM
    {
        public Guid ID { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public bool? EmailOnayliMi { get; set; }

        public bool? AktifMi { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }
        public override string ToString()
        {
            return Adi + ' ' + Soyadi;
        }
    }
}
