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
    public class KullaniciDAL
    {
        public KullaniciSelectVM KullaniciGetir(Guid urunID)
        {
            Model1 db = new Model1();

            var returnData = (from k in db.Kullanici
                                                   join kr in db.KullaniciRolu on k.ID equals kr.KullaniciID
                                                   join u in db.Urun on kr.ID equals u.OlusturanKullaniciRolID
                                                   join o in db.UrunOnay on u.ID equals o.UrunID
                                                   where u.ID == urunID && o.KullaniciGozukmeDurumu == true
                                                   select new KullaniciSelectVM()
                                                   {
                                                       ID = k.ID,
                                                       Adi = k.Adi

                                                   }).FirstOrDefault();
            return returnData;
        }
    }
}
