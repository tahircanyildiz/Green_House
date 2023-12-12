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
    public class AdminBilesenDAL
    {
        public List<AdminBilesenVM> Get()
        {
            return new MyEntityMapper().Map<List<AdminBilesenVM>, List<Bilesen>>(new EFRepo<Bilesen>().SelectAll());
        }
        public AdminBilesenVM Add(AdminBilesenVM bilesenVM)
        {
            if (new EFRepo<Bilesen>().MukerrerMi(x => x.Adi ==bilesenVM.Adi))
            {
                throw new Exception("Bilesen Mevcut");
            }
            MyEntityMapper map = new MyEntityMapper();
            return map.Map<AdminBilesenVM, Bilesen>(new EFRepo<Bilesen>().Add(map.Map<Bilesen, AdminBilesenVM>(bilesenVM)));
        }

        public AdminBilesenVM HardDelete(AdminBilesenVM bilesenVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminBilesenVM, Bilesen>(new EFRepo<Bilesen>().HardDelete(mapper.Map<Bilesen, AdminBilesenVM>(bilesenVM)));
        }
        public AdminBilesenVM SoftDelete(AdminBilesenVM bilesenVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminBilesenVM, Bilesen>(new EFRepo<Bilesen>().SoftDelete(mapper.Map<Bilesen, AdminBilesenVM>(bilesenVM)));
        }

        public AdminBilesenVM Update(AdminBilesenVM bilesenVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminBilesenVM, Bilesen>(new EFRepo<Bilesen>().Update(mapper.Map<Bilesen, AdminBilesenVM>(bilesenVM)));
        }
        public AdminBilesenVM GetBilesenByID(Guid ID)
        {
            return new MyEntityMapper().Map<AdminBilesenVM, Bilesen>(new EFRepo<Bilesen>().SelectOneById(a => a.ID == ID));
        }
        public List<AdminBilesenVM> GetWithName(string bilesenAdi)
        {
            Model1 db = new Model1();
            List<Bilesen> bilesenler = (from b in db.Bilesen
                                        where b.Adi.Contains(bilesenAdi)
                                        select b).ToList();
            return new MyEntityMapper().Map<List<AdminBilesenVM>, List<Bilesen>>(bilesenler);
        }


    }
}
