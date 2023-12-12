using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class UrunOnayInsertVM
    {
        public Guid ID { get; set; }
        public string TakipNumarasi { get; set; }
        public Guid UrunID { get; set; }
        public bool KullaniciGozukmeDurumu { get; set; }
        public Guid? EkleyenKullaniciRolID { get; set; }
        public Guid? InceleyenKullaniciRolID { get; set; }
        public bool? OnayDurumu { get; set; }

    }
}
