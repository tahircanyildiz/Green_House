using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class KullaniciPremiumTipBLL
    {
        KullaniciPremiumTipDAL tipDAL;
        public KullaniciPremiumTipBLL()
        {
            tipDAL = new KullaniciPremiumTipDAL();
        }

        public List<KullaniciPremiumTipVM> GetKullaniciPremiumTipBLL()
        {
            return tipDAL.GetirPremiumTip();
        }
    }
}
