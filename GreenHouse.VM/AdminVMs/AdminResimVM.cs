using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminResimVM
    {
        public Guid ID { get; set; }
        public Guid? UrunID { get; set; }
        public bool? ResimYuzu { get; set; }
        public string ResimYolu { get; set; }
        public bool? AktifMi { get; set; }

        public override string ToString()
        {
            return ResimYolu;
        }
    }
}
