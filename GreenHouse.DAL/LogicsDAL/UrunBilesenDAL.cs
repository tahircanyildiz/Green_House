using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class UrunBilesenDAL
    {
        public List<UrunBilesenVM> UrunBilesikGetir(UrunVM urun)
        {
            return new EFRepo<UrunIcerik>().SelectAllWithInclude(a => a.UrunID == urun.ID, "Urun", "Bilesen").Select(a => new UrunBilesenVM()
            {
                UrunID = a.UrunID,
                BilesenID = a.BilesenID,
                Urun = a.Urun,
                Bilesen = a.Bilesen,               
            }).ToList();
        }

        public bool UrunIcerikEkle(UrunBilesenVM urunBilesenVM)
        {
            EFRepo<UrunIcerik> urunBilesen = null;
            try
            {
                urunBilesen = new EFRepo<UrunIcerik>(new Model1());
                MyMapper<UrunBilesenVM, UrunIcerik> mapper = new MyMapper<UrunBilesenVM, UrunIcerik>();
                UrunIcerik bilesen1 = mapper.Map(urunBilesenVM);
                urunBilesen.Add(bilesen1);
                return true;
            }
            catch
            {
                urunBilesen = null;
                return false;
            }
        }

        
    }
}
