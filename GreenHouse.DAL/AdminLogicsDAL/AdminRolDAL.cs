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
    public class AdminRolDAL
    {
        public List<AdminRolVM> GetAll()
        {
            return new MyEntityMapper().Map<List<AdminRolVM>, List<Rol>>(new EFRepo<Rol>().SelectAll());
        }
        public List<AdminRolVM> GetListWithoutDeleted()
        {
            return new MyEntityMapper().Map<List<AdminRolVM>, List<Rol>>(new EFRepo<Rol>().SelectAll(x=>x.AktifMi==true));
        }
        public AdminRolVM Add(AdminRolVM rolVM)
        {
            MyEntityMapper map = new MyEntityMapper();
            return map.Map<AdminRolVM, Rol>(new EFRepo<Rol>().Add(map.Map<Rol, AdminRolVM>(rolVM)));
        }
        public AdminRolVM HardDelete(AdminRolVM rolVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminRolVM, Rol>(new EFRepo<Rol>().HardDelete(mapper.Map<Rol, AdminRolVM>(rolVM)));
        }
        public AdminRolVM Update(AdminRolVM rolVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminRolVM, Rol>(new EFRepo<Rol>().Update(mapper.Map<Rol, AdminRolVM>(rolVM)));
        }

    }
}
