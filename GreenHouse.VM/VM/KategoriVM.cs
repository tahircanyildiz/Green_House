using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class KategoriVM
    {
        public int ID { get; set; }
        public string KategoriAdi { get; set; }
        public override string ToString()
        {
            return KategoriAdi;
        }
    }
}
