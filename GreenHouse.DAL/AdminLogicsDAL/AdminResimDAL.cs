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
    public class AdminResimDAL
    {
        public List<AdminResimVM> GetResimlerWithUrunID(AdminUrunVM adminUrunVM)
        {
            return new MyEntityMapper().Map<List<AdminResimVM>, List<Resim>>(new EFRepo<Resim>().SelectAll(x => x.UrunID == adminUrunVM.ID)); 
        }
        public AdminResimVM Add(AdminResimVM adminResimVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminResimVM, Resim>(new EFRepo<Resim>().Add(mapper.Map<Resim, AdminResimVM>(adminResimVM)));
        }
        public AdminResimVM Delete(AdminResimVM adminResimVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminResimVM, Resim>(new EFRepo<Resim>().HardDelete(mapper.Map<Resim, AdminResimVM>(adminResimVM)));
        }
        public AdminResimVM Update(AdminResimVM adminResimVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminResimVM, Resim>(new EFRepo<Resim>().Update(mapper.Map<Resim, AdminResimVM>(adminResimVM)));
        }
    }
}
