using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class UrunFirmaBLL
    {
        UrunFirmaDAL firmaDAL;
        public UrunFirmaBLL()
        {
            firmaDAL = new UrunFirmaDAL();
        }
        public List<FirmaVM> FirmaGetirBLL()
        {
            return firmaDAL.FirmaGetir();
        }

        public bool EkleUrunFirmaBLL(UrunFirmaVM urunFirmaVM)
        {
            return firmaDAL.EkleUrunFirma(urunFirmaVM);
        }
    }
}
