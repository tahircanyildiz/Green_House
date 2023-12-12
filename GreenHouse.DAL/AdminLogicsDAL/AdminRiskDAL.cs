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
    public class AdminRiskDAL
    {
        public List<AdminRiskVM> Get()
        {
            return new MyEntityMapper().Map<List<AdminRiskVM>, List<Risk>>(new EFRepo<Risk>().SelectAll());
        }
        public AdminRiskVM Add(AdminRiskVM riskVM)
        {
            if (new EFRepo<Risk>().MukerrerMi(x => x.RiskTur == riskVM.RiskTur))
            {
                throw new Exception("Risk Mevcut");
            }
            MyEntityMapper map = new MyEntityMapper();
            return map.Map<AdminRiskVM, Risk>(new EFRepo<Risk>().Add(map.Map<Risk, AdminRiskVM>(riskVM)));
        }
        public AdminRiskVM HardDelete(AdminRiskVM riskVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminRiskVM, Risk>(new EFRepo<Risk>().HardDelete(mapper.Map<Risk, AdminRiskVM>(riskVM)));
        }
        public AdminRiskVM SoftDelete(AdminRiskVM riskVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminRiskVM, Risk>(new EFRepo<Risk>().SoftDelete(mapper.Map<Risk, AdminRiskVM>(riskVM)));
        }
        public AdminRiskVM Update(AdminRiskVM riskVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminRiskVM, Risk>(new EFRepo<Risk>().Update(mapper.Map<Risk, AdminRiskVM>(riskVM)));
        }
        public AdminRiskVM GetRiskByID(int id)
        {
            return new MyEntityMapper().Map<AdminRiskVM, Risk>(new EFRepo<Risk>().SelectOneById(a => a.ID == id));
        }
    }
}
