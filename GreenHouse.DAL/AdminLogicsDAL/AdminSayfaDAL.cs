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
    public class AdminSayfaDAL
    {
        public List<AdminSayfaVM> GetAll()
        {
            return new MyEntityMapper().Map<List<AdminSayfaVM>, List<Sayfa>>(new EFRepo<Sayfa>().SelectAll());
        }
        public List<AdminSayfaVM> GetSayfalarWithName(string name)
        {
            Model1 db = new Model1();
            List<Sayfa> liste = (from y in db.Sayfa
                                 where y.SayfaAdi.Contains(name)
                                 select y).ToList();
            return new MyEntityMapper().Map<List<AdminSayfaVM>, List<Sayfa>>(liste);
        }
        public AdminSayfaVM Add(AdminSayfaVM sayfaVM)
        {
            MyEntityMapper map = new MyEntityMapper();
            if (new EFRepo<Sayfa>().MukerrerMi(x => x.SayfaAdi == sayfaVM.SayfaAdi))
            {
                throw new Exception("Sayfa Mevcut.");
            }
            return map.Map<AdminSayfaVM, Sayfa>(new EFRepo<Sayfa>().Add(map.Map<Sayfa, AdminSayfaVM>(sayfaVM)));
        }
        public AdminSayfaVM Delete(AdminSayfaVM sayfaVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminSayfaVM, Sayfa>(new EFRepo<Sayfa>().HardDelete(mapper.Map<Sayfa, AdminSayfaVM>(sayfaVM)));
        }
        public AdminSayfaVM Update(AdminSayfaVM sayfaVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminSayfaVM, Sayfa>(new EFRepo<Sayfa>().Update(mapper.Map<Sayfa, AdminSayfaVM>(sayfaVM)));
        }
    }
}
