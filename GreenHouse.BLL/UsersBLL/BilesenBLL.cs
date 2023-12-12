using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class BilesenBLL
    {
        BilesenDAL bilesenDAL;
        public BilesenBLL()
        {
            bilesenDAL = new BilesenDAL();
        }
        public List<BilesenVM> UrunBilesikGetirBLL(UrunBilesenVM urun)
        {
            return bilesenDAL.UrunBilesikGetir(urun);
        }

        public BilesenVM BilesenEkleBLL(BilesenVM bilesenVM)
        {
            return bilesenDAL.BilesenEkle(bilesenVM);
        }

        public List<BilesenVM> TumBilesenGetirBLL()
        {
            return bilesenDAL.TumBilesenGetir();
        }
        public BilesenVM IDIleGetirBLL(Guid ID)
        {
            return bilesenDAL.IDIleGetir(ID);
        }
        public bool UrunBilesenEkleTransaction(List<Tuple<string, int, string>> values, UrunVM urun)
        {
            return bilesenDAL.UrunBilesenEkleTransaction(values, urun);
        }

    }
}
