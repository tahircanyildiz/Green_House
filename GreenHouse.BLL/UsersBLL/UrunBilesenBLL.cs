using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class UrunBilesenBLL
    {
        UrunBilesenDAL bilesenDAL;
        public UrunBilesenBLL()
        {
            bilesenDAL = new UrunBilesenDAL();
        }
        public List<UrunBilesenVM> UrunBilesikGetirBLL(UrunVM urun)
        {

            return bilesenDAL.UrunBilesikGetir(urun);
        }

        public bool UrunIcerikEkleBLL(UrunBilesenVM urunBilesenVM)
        {
            return bilesenDAL.UrunIcerikEkle(urunBilesenVM);
        }
    }
}
