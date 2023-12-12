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
   public class AdminMenuElemanDAL
    {
        public List<AdminElemanVM> GetElemanListWithMenuID(AdminMenuVM adminMenuVM)
        {
            Model1 db = new Model1();

            List<AdminElemanVM> returnList = (from e in db.Eleman
                                            join me in db.MenuEleman on e.ID equals me.ElemanID
                                            join m in db.Menu on me.MenuID equals m.ID
                                            where m.ID == adminMenuVM.ID
                                            orderby e.MenuElemanSirasi
                                            select new AdminElemanVM()
                                            {
                                                ID=e.ID,
                                                AktifMi=e.AktifMi,
                                                MenuElemanAdi=e.MenuElemanAdi,
                                                MenuElemanSirasi=e.MenuElemanSirasi,
                                                MenuIconYolu=e.MenuIconYolu,
                                                MenuLinkAdresi=e.MenuLinkAdresi
                                            }).ToList();
            return returnList;
        }
        public List<AdminMenuVM> GetMenuListWithElemanID(AdminElemanVM adminElemanVM)
        {
            Model1 db = new Model1();

            List<AdminMenuVM> returnList = (from m in db.Menu
                                              join me in db.MenuEleman on m.ID equals me.MenuID
                                              join e in db.Eleman on me.ElemanID equals e.ID
                                              where e.ID == adminElemanVM.ID
                                              select new AdminMenuVM()
                                              {
                                                  ID=m.ID,
                                                  MenuAdi=m.MenuAdi
                                              }).ToList();
            return returnList;
        }
        public AdminMenuElemanVM Delete(AdminMenuElemanVM adminMenuElemanVM)
        {
            EFRepo<MenuEleman> efRepo = new EFRepo<MenuEleman>();
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminMenuElemanVM, MenuEleman>(efRepo.HardDelete(efRepo.SelectOneById(x => x.ElemanID == adminMenuElemanVM.ElemanID && x.MenuID == adminMenuElemanVM.MenuID)));
        }
        public AdminMenuElemanVM Add(AdminMenuElemanVM adminMenuElemanVM)
        {
            MyEntityMapper map = new MyEntityMapper();
            return map.Map<AdminMenuElemanVM, MenuEleman>(new EFRepo<MenuEleman>().Add(map.Map<MenuEleman, AdminMenuElemanVM>(adminMenuElemanVM)));
        }
    }
}
