using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminListeIcerigiVM
    {
        public Guid ID { get; set; }

        public Guid ListeID { get; set; }

        public bool? UrunMu { get; set; }

        public Guid UrunID { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }

        public virtual KullaniciListesi KullaniciListesi { get; set; }
    }
}
