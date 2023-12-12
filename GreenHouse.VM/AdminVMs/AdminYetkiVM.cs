using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminYetkiVM
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
