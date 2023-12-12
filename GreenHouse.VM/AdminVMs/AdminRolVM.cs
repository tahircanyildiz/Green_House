using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
   public class AdminRolVM
    {
        public int ID { get; set; }

        public string RolAdi { get; set; }

        public bool? AktifMi { get; set; }

        public override string ToString()
        {
            return RolAdi;
        }
    }
}
