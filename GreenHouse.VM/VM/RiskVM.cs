using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class RiskVM
    {
        public int ID { get; set; }
        public string RiskTur { get; set; }
        public bool AktifMi { get; set; }
        public override string ToString()
        {
            return RiskTur;
        }
    }
}
