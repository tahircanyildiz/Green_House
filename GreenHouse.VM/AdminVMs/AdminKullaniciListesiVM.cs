using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminKullaniciListesiVM
    {

        public Guid ID { get; set; }

        public string ListeAdi { get; set; }

        public Guid? ÜstListeID { get; set; }

        public Guid? KullaniciRolID { get; set; }

        public int? ListeTipiID { get; set; }

        public bool? AktifMi { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }

    }
}
