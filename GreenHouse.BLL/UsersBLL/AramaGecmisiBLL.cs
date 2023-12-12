using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class AramaGecmisiBLL
    {
        AramaGecmisiDAL gecmisiDAL;

        public AramaGecmisiBLL()
        {
            gecmisiDAL = new AramaGecmisiDAL();
        }

        public List<AramaGecmisiVM> GetirAramaGecmisiBLL(Guid kullaniciID)
        {
            return gecmisiDAL.GetirAramaGecmisi(kullaniciID);
        }

        public bool EkleAramaGecmisiBLL(AramaGecmisiVM aramaGecmisiVM)
        {
            return gecmisiDAL.EkleAramaGecmisi(aramaGecmisiVM);
        }

        public bool SilAramaGecmisiBLL(AramaGecmisiVM aramaGecmisiVM)
        {
            return gecmisiDAL.SilAramaGecmisi(aramaGecmisiVM);
        }

        public bool SilTümAramaGecmisiBLL(List<AramaGecmisiVM> aramaGecmisiVMs)
        {
            return gecmisiDAL.SilTümAramaGecmisi(aramaGecmisiVMs);
        }
    }
}
