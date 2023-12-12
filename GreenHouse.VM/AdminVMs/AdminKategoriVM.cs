using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
   public  class AdminKategoriVM
    {
        public int ID { get; set; }

        public string KategoriAdi { get; set; }

        public int? UstKategoriID { get; set; }

        public bool? AktifMi { get; set; }
        public override string ToString()
        {
            return KategoriAdi;
        }
    }
}
