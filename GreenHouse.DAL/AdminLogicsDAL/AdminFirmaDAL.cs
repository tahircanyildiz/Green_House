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
    public class AdminFirmaDAL
    {
        public List<AdminFirmaVM> Get()
        {
            return new MyEntityMapper().Map<List<AdminFirmaVM>, List<Firma>>(new EFRepo<Firma>().SelectAll());
        }
        public AdminFirmaVM Add(AdminFirmaVM firmaVM)
        {
            if (new EFRepo<Firma>().MukerrerMi(x => x.FirmaAdi == firmaVM.FirmaAdi))
            {
                throw new Exception("Firma Mevcut");
            }
            MyEntityMapper map = new MyEntityMapper();
            return map.Map<AdminFirmaVM, Firma>(new EFRepo<Firma>().Add(map.Map<Firma, AdminFirmaVM>(firmaVM)));
        }
        public AdminFirmaVM HardDelete(AdminFirmaVM firmaVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminFirmaVM, Firma>(new EFRepo<Firma>().HardDelete(mapper.Map<Firma, AdminFirmaVM>(firmaVM)));
        }
        public AdminFirmaVM SoftDelete(AdminFirmaVM firmaVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminFirmaVM, Firma>(new EFRepo<Firma>().SoftDelete(mapper.Map<Firma, AdminFirmaVM>(firmaVM)));
        }
        public AdminFirmaVM Update(AdminFirmaVM firmaVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminFirmaVM, Firma>(new EFRepo<Firma>().Update(mapper.Map<Firma, AdminFirmaVM>(firmaVM)));
        }
        public List<AdminFirmaVM> GetWithName(string firmaAdi)
        {
            Model1 db = new Model1();
            List<Firma> firmas = (from y in db.Firma
                                  where y.FirmaAdi.Contains(firmaAdi)
                                  select y).ToList();
            return new MyEntityMapper().Map<List<AdminFirmaVM>, List<Firma>>(firmas);
        }
    }
}
