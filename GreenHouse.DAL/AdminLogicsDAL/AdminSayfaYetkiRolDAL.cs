using GreenHouse.VM.AdminVMs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.AdminLogicsDAL
{
    public class AdminSayfaYetkiRolDAL
    {
        public List<AdminRolVM> GetRollerListWithSayfaID(AdminSayfaVM adminSayfaVM)
        {
            Model1 db = new Model1();

            List<AdminRolVM> returnList = (from r in db.Rol
                                            join sy in db.SayfaYetki on r.ID equals sy.RolID
                                            join s in db.Sayfa on sy.SayfaID equals s.ID
                                            where s.ID == adminSayfaVM.ID
                                            select new AdminRolVM()
                                            {
                                                RolAdi=r.RolAdi,
                                                ID=r.ID,
                                                AktifMi=r.AktifMi                                                
                                            }).ToList();
            return returnList;
        }
        public List<AdminYetkiVM> GetYetkilerWithSayfaRolID(AdminSayfaVM adminSayfaVM,AdminRolVM adminRolVM)
        {
            Model1 db = new Model1();
            List<AdminYetkiVM> returnList = (from y in db.Yetki
                                             join sy in db.SayfaYetki on y.ID equals sy.YetkiID
                                             join s in db.Sayfa on sy.SayfaID equals s.ID
                                             join r in db.Rol on sy.RolID equals r.ID
                                             where s.ID==adminSayfaVM.ID && r.ID == adminRolVM.ID
                                             select new AdminYetkiVM()
                                             {
                                                 Adi=y.Adi,
                                                 ID=y.ID
                                             }).ToList();
            return returnList;
        }

    }
}
