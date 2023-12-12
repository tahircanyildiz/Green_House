using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.AdminVMs
{
    public class AdminMenuVM
    {
        public int ID { get; set; }

        public string MenuAdi { get; set; }
        public override string ToString()
        {
            return MenuAdi;
        }
    }
}
