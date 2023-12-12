using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class UrunVeOnayDurumuSelectVM
    {
        public Guid ID { get; set; }
        public Guid UrunID { get; set; }
        public bool? OnayDurumu { get; set; }
        public string TakipNumarasi { get; set; }
        public Urun Urun { get; set; }


    }
}
