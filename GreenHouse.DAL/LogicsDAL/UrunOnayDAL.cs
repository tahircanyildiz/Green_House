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
    public class UrunOnayDAL
    {
        public UrunOnayInsertVM EkleUrunOnay(UrunOnayInsertVM urunOnayInsertVM)
        {
            EFRepo<UrunOnay> urun = null;
            try
            {
                urun = new EFRepo<UrunOnay>(new Model1());
                MyMapper<UrunOnayInsertVM, UrunOnay> mapper = new MyMapper<UrunOnayInsertVM, UrunOnay>();
                UrunOnay urun1 = mapper.Map(urunOnayInsertVM);
                urun.Add(urun1);
                return urunOnayInsertVM;
            }
            catch
            {
                urun = null;
                return null;
            }
        }

        public List<UrunVeOnayDurumuSelectVM> KullaniciUrunGetir(Guid kullaniciID)
        {
            try
            {
                Model1 context = new Model1();
                List<UrunVeOnayDurumuSelectVM> resultList = new List<UrunVeOnayDurumuSelectVM>();
                var secilenUrun = (from s in context.UrunOnay
                                   join uo in context.Urun on s.UrunID equals uo.ID
                                   join kr in context.KullaniciRolu on s.EkleyenKullaniciRolID equals kr.ID
                                   join k in context.Kullanici on kr.KullaniciID equals k.ID
                                   where k.ID == kullaniciID
                                   select s).ToList();
                MyMapper<UrunOnay, UrunVeOnayDurumuSelectVM> mapper = new MyMapper<UrunOnay, UrunVeOnayDurumuSelectVM>();
                foreach (var item in secilenUrun)
                {
                    var result = mapper.Map(item);
                    resultList.Add(result);
                }
                return resultList;
            }
            catch
            {
                return null;
            }
        }
    }
}
