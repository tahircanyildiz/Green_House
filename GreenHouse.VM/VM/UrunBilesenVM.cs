using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class UrunBilesenVM
    {
        public Guid UrunID { get; set; }
        public Guid BilesenID { get; set; }
        public virtual Bilesen Bilesen { get; set; }
        public virtual Urun Urun { get; set; }


    }
}
