using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class KullaniciPremiumTipVM
    {
        public int ID { get; set; }
        public string TipAdı { get; set; }
        public int HedefPuan { get; set; }

        public override string ToString()
        {
            return TipAdı;
        }
    }
}
