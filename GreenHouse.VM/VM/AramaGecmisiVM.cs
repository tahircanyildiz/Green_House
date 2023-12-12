using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.VM
{
    public class AramaGecmisiVM
    {
        public Guid ID { get; set; }
        public string AramaMetni { get; set; }
        public Guid KullaniciID { get; set; }
        public DateTime AramaZamani { get; set; }
        public bool AktifMi { get; set; }

        public override string ToString()
        {
            return AramaMetni;
        }
    }
}
