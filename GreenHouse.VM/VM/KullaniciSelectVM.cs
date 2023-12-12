using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class KullaniciSelectVM
    {
        public Guid ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool EmailOnaylandiMi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public bool AktifMi { get; set; }

    }
}
