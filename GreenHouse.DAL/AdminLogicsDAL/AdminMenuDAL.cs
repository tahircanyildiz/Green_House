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
    public class AdminMenuDAL
    {
        public List<AdminMenuVM> GetAll()
        {
            return new MyEntityMapper().Map<List<AdminMenuVM>, List<Menu>>(new EFRepo<Menu>().SelectAll());
        }
        public List<AdminMenuVM> GetMenulerWithName(string name)
        {
            Model1 db = new Model1();
            List<Menu> liste = (from m in db.Menu
                                 where m.MenuAdi.Contains(name)
                                 select m).ToList();
            return new MyEntityMapper().Map<List<AdminMenuVM>, List<Menu>>(liste);
        }
        public AdminMenuVM Add(AdminMenuVM menuVM)
        {
            EFRepo<Menu> eFRepo = new EFRepo<Menu>();
            MyEntityMapper map = new MyEntityMapper();
            if (eFRepo.MukerrerMi(x=>x.MenuAdi==menuVM.MenuAdi))
            {
                throw new Exception("Menu Mevcut.");
            }
            return map.Map<AdminMenuVM, Menu>(new EFRepo<Menu>().Add(map.Map<Menu, AdminMenuVM>(menuVM)));
        }
        public AdminMenuVM Delete(AdminMenuVM menuVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminMenuVM, Menu>(new EFRepo<Menu>().HardDelete(mapper.Map<Menu, AdminMenuVM>(menuVM)));
        }
        public AdminMenuVM Update(AdminMenuVM menuVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminMenuVM, Menu>(new EFRepo<Menu>().Update(mapper.Map<Menu, AdminMenuVM>(menuVM)));
        }
    }
}
