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
    public class AdminElemanDAL
    {
        public List<AdminElemanVM> GetAll()
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<List<AdminElemanVM>, List<Eleman>>(new EFRepo<Eleman>().SelectAll());
        }
        public List<AdminElemanVM> GetAllAktif()
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<List<AdminElemanVM>, List<Eleman>>(new EFRepo<Eleman>().SelectAll(x => x.AktifMi == true));
        }
        public List<AdminElemanVM> GetElemanlarWithName(string name)
        {
            Model1 db = new Model1();
            List<Eleman> liste = (from ua in db.Eleman
                                        where ua.MenuElemanAdi.Contains(name)
                                        select ua).ToList();
            return new MyEntityMapper().Map<List<AdminElemanVM>, List<Eleman>>(liste);
        }
        public AdminElemanVM Add(AdminElemanVM adminElemanVM)
        {
            MyEntityMapper map = new MyEntityMapper();
            if (new EFRepo<Eleman>().MukerrerMi(x => x.MenuElemanAdi == adminElemanVM.MenuElemanAdi))
            {
                throw new Exception("Eleman Mevcut.");
            }
            return map.Map<AdminElemanVM, Eleman>(new EFRepo<Eleman>().Add(map.Map<Eleman, AdminElemanVM>(adminElemanVM)));
        }
        public AdminElemanVM Delete(AdminElemanVM adminElemanVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminElemanVM, Eleman>(new EFRepo<Eleman>().HardDelete(mapper.Map<Eleman, AdminElemanVM>(adminElemanVM)));
        }
        public AdminElemanVM Update(AdminElemanVM adminElemanVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminElemanVM, Eleman>(new EFRepo<Eleman>().Update(mapper.Map<Eleman, AdminElemanVM>(adminElemanVM)));
        }
    }
}
