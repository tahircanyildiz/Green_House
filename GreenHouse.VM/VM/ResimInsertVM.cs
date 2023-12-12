using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class ResimInsertVM
    {
        public Guid ID { get; set; }
        public Guid UrunID { get; set; }
        public bool ResimYuzu { get; set; }
        public string ResimYolu { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public Guid OlusturanKullaniciRolID { get; set; }
        public DateTime DegistirmeTarihi { get; set; }
        public Guid DegistirenKullaniciRolID { get; set; }
    }
}
