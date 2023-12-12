using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.VM.AdminVMs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.AdminLogicsDAL
{
    public class AdminUrunIcerikDAL
    {
        public List<AdminBilesenVM> GetBilesenListWithUrunID(AdminUrunVM adminUrunVM)
        {
            Model1 db = new Model1();

            List<AdminBilesenVM> returnList = (from b in db.Bilesen
                                            join bu in db.UrunIcerik on b.ID equals bu.BilesenID
                                            join u in db.Urun on bu.UrunID equals u.ID
                                            where u.ID == adminUrunVM.ID
                                            select new AdminBilesenVM()
                                            {
                                                Adi=b.Adi,
                                                ID=b.ID,
                                                Aciklama=b.Aciklama,
                                                AktifMi=b.AktifMi,
                                                DegistirenKullaniciRolID=b.DegistirenKullaniciRolID,
                                                DegistirilmeTarihi=b.DegistirilmeTarihi,
                                                OlusturanKullaniciRolID=b.OlusturanKullaniciRolID,
                                                OlusturulmaTarihi=b.OlusturulmaTarihi,
                                                Risk=b.Risk,
                                                RiskID=b.RiskID
                                            }).ToList();
            return returnList;
        }
        public List<AdminUrunVM> GetUrunListWithBilesenID(AdminBilesenVM bilesenVM)
        {
            Model1 db = new Model1();

            List<AdminUrunVM> returnList = (from u in db.Urun
                                            join bu in db.UrunIcerik on u.ID equals bu.UrunID
                                          join b in db.Bilesen on bu.BilesenID equals b.ID
                                          where b.ID == bilesenVM.ID
                                          select new AdminUrunVM()
                                          {
                                              ID=u.ID,
                                              AktifMi=u.AktifMi,
                                              BarkodNumarasi=u.BarkodNumarasi,
                                              KategoriID=u.KategoriID,
                                              UrunAciklamasi=u.UrunAciklamasi,
                                              UrunAdi=u.UrunAdi
                                          }).ToList();
            return returnList;
        }
        public AdminUrunIcerikVM Add(AdminUrunIcerikVM adminUrunIcerikVM)
        {
            MyEntityMapper map = new MyEntityMapper();
            return map.Map<AdminUrunIcerikVM, UrunIcerik>(new EFRepo<UrunIcerik>().Add(map.Map<UrunIcerik, AdminUrunIcerikVM>(adminUrunIcerikVM)));
        }
        public AdminUrunIcerikVM Delete(AdminUrunIcerikVM adminUrunIcerikVM)
        {
            EFRepo<UrunIcerik> efRepo = new EFRepo<UrunIcerik>();
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminUrunIcerikVM, UrunIcerik>(efRepo.HardDelete(efRepo.SelectOneById(x => x.UrunID == adminUrunIcerikVM.UrunID && x.BilesenID == adminUrunIcerikVM.BilesenID)));
        }
    }
}
