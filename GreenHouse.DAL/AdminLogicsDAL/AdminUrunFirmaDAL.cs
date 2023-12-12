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
    public class AdminUrunFirmaDAL
    {
        public List<AdminUrunFirmaVM> GetAll()
        {

            return new MyEntityMapper().Map<List<AdminUrunFirmaVM>, List<UrunFirma>>(new EFRepo<UrunFirma>().SelectAll());
        }
        public List<AdminUrunVM> GetUrunListWithFirmaID(AdminFirmaVM adminFirmaVM)
        {
            Model1 db = new Model1();

            List<AdminUrunVM> returnList = (from u in db.Urun
                                            join uf in db.UrunFirma on u.ID equals uf.UrunID
                                            join f in db.Firma on uf.FirmaID equals f.ID
                                            where f.ID == adminFirmaVM.ID
                                            select new AdminUrunVM()
                                            {
                                                ID = u.ID,
                                                BarkodNumarasi = u.BarkodNumarasi,
                                                KategoriID = u.KategoriID,
                                                UrunAciklamasi = u.UrunAciklamasi,
                                                UrunAdi = u.UrunAdi,
                                                AktifMi = u.AktifMi
                                            }).ToList();
            return returnList;
        }
        public List<AdminFirmaVM> GetFirmaListWithUrunID(AdminUrunVM adminUrunVM)
        {
            Model1 db = new Model1();

            List<AdminFirmaVM> returnList = (from f in db.Firma
                                             join uf in db.UrunFirma on f.ID equals uf.FirmaID
                                             join u in db.Urun on uf.UrunID equals u.ID
                                             where u.ID == adminUrunVM.ID
                                             select new AdminFirmaVM()
                                             {
                                                 ID = f.ID,
                                                 FirmaAdi=f.FirmaAdi,
                                                 FirmaAdresi=f.FirmaAdresi,
                                                 FirmaTel=f.FirmaTel,
                                                 AktifMi=f.AktifMi
                                             }).ToList();
            return returnList;
        }
        public AdminUrunFirmaVM Delete(AdminUrunFirmaVM adminUrunFirmaVM)
        {
            EFRepo<UrunFirma> efRepo = new EFRepo<UrunFirma>();
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminUrunFirmaVM, UrunFirma>(efRepo.HardDelete(efRepo.SelectOneById(x => x.UrunID == adminUrunFirmaVM.UrunID && x.FirmaID == adminUrunFirmaVM.FirmaID)));
        }

        public AdminUrunFirmaVM Add(AdminUrunFirmaVM adminUrunFirmaVM)
        {
            MyEntityMapper map = new MyEntityMapper();
            return map.Map<AdminUrunFirmaVM, UrunFirma>(new EFRepo<UrunFirma>().Add(map.Map<UrunFirma, AdminUrunFirmaVM>(adminUrunFirmaVM)));
        }
    }
}
