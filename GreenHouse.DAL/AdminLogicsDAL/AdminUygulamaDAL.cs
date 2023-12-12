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
    public class AdminUygulamaDAL
    {
        public List<AdminUygulamaVM> GetAll()
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<List<AdminUygulamaVM>, List<UygulamaAyar>>(new EFRepo<UygulamaAyar>().SelectAll());
        }
        public List<AdminUygulamaVM> GetAllAktif()
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<List<AdminUygulamaVM>, List<UygulamaAyar>>(new EFRepo<UygulamaAyar>().SelectAll(x=>x.AktifMi==true));
        }
        public List<AdminUygulamaVM> GetUygulamaWithName(string name)
        {
            Model1 db = new Model1();
            List<UygulamaAyar> liste = (from ua in db.UygulamaAyar
                                 where ua.Adi.Contains(name)
                                 select ua).ToList();
            return new MyEntityMapper().Map<List<AdminUygulamaVM>, List<UygulamaAyar>>(liste);
        }
        public AdminUygulamaVM Add(AdminUygulamaVM adminUygulamaVM)
        {
            if (new EFRepo<UygulamaAyar>().MukerrerMi(x => x.Adi == adminUygulamaVM.Adi))
            {
                throw new Exception("Uygulama Ayarı Mevcut");
            }
            MyEntityMapper map = new MyEntityMapper();
            return map.Map<AdminUygulamaVM, UygulamaAyar>(new EFRepo<UygulamaAyar>().Add(map.Map<UygulamaAyar, AdminUygulamaVM>(adminUygulamaVM)));
        }
        public AdminUygulamaVM Delete(AdminUygulamaVM adminUygulamaVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminUygulamaVM, UygulamaAyar>(new EFRepo<UygulamaAyar>().HardDelete(mapper.Map<UygulamaAyar, AdminUygulamaVM>(adminUygulamaVM)));
        }
        public AdminUygulamaVM Update(AdminUygulamaVM adminUygulamaVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminUygulamaVM, UygulamaAyar>(new EFRepo<UygulamaAyar>().Update(mapper.Map<UygulamaAyar, AdminUygulamaVM>(adminUygulamaVM)));
        }

    }
}
