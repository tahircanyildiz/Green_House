using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.Core.Entities;
using GreenHouse.VM.AdminVMs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.AdminLogicsDAL
{
    public class AdminSayfaMenuDAL
    {
        public List<AdminMenuVM> GetMenulerListWithSayfaID(AdminSayfaVM adminSayfaVM)
        {
            Model1 db = new Model1();

            List<AdminMenuVM> returnList = (from m in db.Menu
                                            join sm in db.SayfaMenu on m.ID equals sm.MenuID
                                            join s in db.Sayfa on sm.SayfaID equals s.ID
                                            where s.ID == adminSayfaVM.ID
                                            select new AdminMenuVM()
                                            {
                                                ID=m.ID,
                                                MenuAdi=m.MenuAdi
                                            }).ToList();
            return returnList;
        }
        public List<AdminSayfaVM> GetSayfalarListWithMenuID(AdminMenuVM adminMenuVM)
        {
            Model1 db = new Model1();

            List<AdminSayfaVM> returnList = (from s in db.Sayfa
                                             join sm in db.SayfaMenu on s.ID equals sm.SayfaID
                                             join m in db.Menu on sm.MenuID equals m.ID
                                             where m.ID == adminMenuVM.ID
                                             select new AdminSayfaVM()
                                             {
                                               ID = s.ID,
                                               SayfaAdi=s.SayfaAdi
                                             }).ToList();
            return returnList;
        }

        public List<AdminMenuVM> GetMenulerListWithSayfaAdi(string sayfaAdi)
        {
            Model1 db = new Model1();

            List<AdminMenuVM> returnList = (from m in db.Menu
                                            join sm in db.SayfaMenu on m.ID equals sm.MenuID
                                            join s in db.Sayfa on sm.SayfaID equals s.ID
                                            where s.SayfaAdi == sayfaAdi
                                            select new AdminMenuVM()
                                            {
                                                ID = m.ID,
                                                MenuAdi = m.MenuAdi
                                            }).ToList();
            return returnList;
        }

        public AdminSayfaMenuVM Delete(AdminSayfaMenuVM adminSayfaMenuVM)
        {
            EFRepo<SayfaMenu> efRepo = new EFRepo<SayfaMenu>();
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminSayfaMenuVM, SayfaMenu>(efRepo.HardDelete(efRepo.SelectOneById(x => x.MenuID == adminSayfaMenuVM.MenuID && x.SayfaID == adminSayfaMenuVM.SayfaID)));
        }
        public AdminSayfaMenuVM Add(AdminSayfaMenuVM adminSayfaMenuVM)
        {
            MyEntityMapper map = new MyEntityMapper();
            return map.Map<AdminSayfaMenuVM, SayfaMenu>(new EFRepo<SayfaMenu>().Add(map.Map<SayfaMenu, AdminSayfaMenuVM>(adminSayfaMenuVM)));
        }
    }
}
