using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class RiskDAL
    {
        public RiskVM RiskGetir(UrunBilesenVM urunBilesenVM)
        {
            MyMapper<Risk, RiskVM> mapper = new MyMapper<Risk, RiskVM>();
            var result = mapper.Map(new EFRepo<Risk>().SelectById(urunBilesenVM.Bilesen.RiskID.ToString()));
            return result;
        }

        public List<RiskVM> TumRiskGetir()
        {
            EFRepo<Risk> risk = new EFRepo<Risk>();
            return risk.SelectAll().Select(a => new RiskVM()
            {
                ID = a.ID,
                RiskTur = a.RiskTur,
                AktifMi = (bool)a.AktifMi
            }).ToList();
        }
        public RiskVM IDIleGetir(int ID)
        {
            EFRepo<Risk> risk = new EFRepo<Risk>();
            MyMapper<Risk, RiskVM> mapper = new MyMapper<Risk, RiskVM>();
            var selected = mapper.Map(risk.SelectByID(ID));
            return selected;
        }
    }
}
