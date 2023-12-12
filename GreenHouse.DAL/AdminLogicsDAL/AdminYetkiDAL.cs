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
    public class AdminYetkiDAL
    {
        public List<AdminYetkiVM> GetAll()
        {
            return new MyEntityMapper().Map<List<AdminYetkiVM>,List<Yetki>>(new EFRepo<Yetki>().SelectAll());
        }
        public List<AdminYetkiVM> GetYetkilerWithName(string name)
        {
            Model1 db = new Model1();
            List<Yetki> liste = (from y in db.Yetki
                                        where y.Adi.Contains(name)
                                        select y).ToList();
            return new MyEntityMapper().Map<List<AdminYetkiVM>, List<Yetki>>(liste);
        }
        public AdminYetkiVM Add(AdminYetkiVM yetkiVM)
        {
            MyEntityMapper map = new MyEntityMapper();
            if (new EFRepo<Yetki>().MukerrerMi(x=>x.Adi == yetkiVM.Adi))
            {
                throw new Exception("Yetki Mevcut.");
            }
            return map.Map<AdminYetkiVM, Yetki>(new EFRepo<Yetki>().Add(map.Map<Yetki, AdminYetkiVM>(yetkiVM)));
        }
        public AdminYetkiVM Delete(AdminYetkiVM yetkiVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminYetkiVM, Yetki>(new EFRepo<Yetki>().HardDelete(mapper.Map<Yetki, AdminYetkiVM>(yetkiVM)));
        }
        public AdminYetkiVM Update(AdminYetkiVM yetkiVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminYetkiVM, Yetki>(new EFRepo<Yetki>().Update(mapper.Map<Yetki, AdminYetkiVM>(yetkiVM)));
        }
    }
}
