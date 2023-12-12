using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class KullaniciUIBLL
    {
        KullaniciDAL kullaniciDAL;
        public KullaniciUIBLL()
        {
            kullaniciDAL = new KullaniciDAL();
        }
        public KullaniciSelectVM KullaniciGetir(Guid urunID)
        {
            return kullaniciDAL.KullaniciGetir(urunID);
        }
    }
}
