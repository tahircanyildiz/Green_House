using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class ResimBLL
    {
        ResimDAL resimDAL;
        public ResimBLL()
        {
            resimDAL = new ResimDAL();
        }

        public List<string> UruneGoreGetir(UrunVM urunVM)
        {
            return resimDAL.UruneGoreGetir(urunVM);
        }
    }
}
