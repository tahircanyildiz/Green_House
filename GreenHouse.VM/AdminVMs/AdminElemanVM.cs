using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminElemanVM
    {
        public int ID { get; set; }
        public string MenuElemanAdi { get; set; }
        public string MenuIconYolu { get; set; }
        public int? MenuElemanSirasi { get; set; }
        public string MenuLinkAdresi { get; set; }
        public bool? AktifMi { get; set; }
        public override string ToString()
        {
            return MenuElemanAdi;
        }
    }
}
