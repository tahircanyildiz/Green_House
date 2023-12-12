using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminUygulamaVM
    {
        public int ID { get; set; }

        public string Adi { get; set; }

        public string LogoResimYolu { get; set; }

        public bool? KullanimKosullariniGostermeDurumu { get; set; }

        public bool? AktifMi { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
