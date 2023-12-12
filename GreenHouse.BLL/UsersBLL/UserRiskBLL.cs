using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class UserRiskBLL
    {
        RiskDAL riskDAL;
        public UserRiskBLL()
        {
            riskDAL = new RiskDAL();
        }
        public RiskVM RiskGetirBLL(UrunBilesenVM urunBilesenVM)
        {
            return riskDAL.RiskGetir(urunBilesenVM);
        }

        public List<RiskVM> TumRiskGetir()
        {
            return riskDAL.TumRiskGetir();
        }
        public RiskVM IDIleGetir(int ID)
        {
            return riskDAL.IDIleGetir(ID);
        }
    }
}
