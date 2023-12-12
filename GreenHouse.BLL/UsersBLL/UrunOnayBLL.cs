using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class UrunOnayBLL
    {
        UrunOnayDAL onayDAL;
        public UrunOnayBLL()
        {
            onayDAL = new UrunOnayDAL();
        }

        public List<UrunVeOnayDurumuSelectVM> KullaniciUrunGetirBLL(Guid kullaniciID)
        {
            return onayDAL.KullaniciUrunGetir(kullaniciID);
        }
    }
}
