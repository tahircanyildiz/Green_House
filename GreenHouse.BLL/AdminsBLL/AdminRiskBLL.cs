using ExceptionHandling;
using GreenHouse.Core.Common;
using GreenHouse.DAL.AdminLogicsDAL;
using GreenHouse.VM.AdminVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.AdminsBLL
{
    public class AdminRiskBLL
    {
        AdminRiskDAL riskDAL = null;
        public AdminRiskBLL()
        {
            riskDAL = new AdminRiskDAL();
        }

        public GeneralReturnType<List<AdminRiskVM>> GetList()
        {
            List<AdminRiskVM> returnData = null;
            try
            {
                returnData = riskDAL.Get();

                return new GeneralReturnType<List<AdminRiskVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminRiskVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        public GeneralReturnType<AdminRiskVM> Add(AdminRiskVM riskVM)
        {
            try
            {
                if (!Extensions.SqlControl(riskVM.RiskTur) || !Extensions.SpaceOrNull(riskVM.RiskTur))
                {
                    throw new Exception("Hatali ya da Eksik Giriş Yapıldı.");
                }

                AdminRiskVM eklenenRisk = riskDAL.Add(riskVM);
                if (eklenenRisk == null)
                {
                    throw new RiskEklenemediException("Risk Eklenemedi.");
                }
                return new GeneralReturnType<AdminRiskVM>()
                {
                    Datas = eklenenRisk,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (RiskEklenemediException ex)
            {
                return new GeneralReturnType<AdminRiskVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 401
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminRiskVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        public GeneralReturnType<AdminRiskVM> HardDelete(AdminRiskVM riskVM)
        {
            try
            {
                AdminRiskVM silinenRisk = riskDAL.HardDelete(riskVM);

                return new GeneralReturnType<AdminRiskVM>()
                {
                    Datas = silinenRisk,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminRiskVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        public GeneralReturnType<AdminRiskVM> SoftDelete(AdminRiskVM riskVM)
        {
            try
            {
                AdminRiskVM silinenRisk = riskDAL.SoftDelete(riskVM);
                return new GeneralReturnType<AdminRiskVM>()
                {
                    Datas = silinenRisk,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminRiskVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        public GeneralReturnType<AdminRiskVM> Update(AdminRiskVM riskVM)
        {
            try
            {
                AdminRiskVM guncellenenRisk = riskDAL.Update(riskVM);
                return new GeneralReturnType<AdminRiskVM>()
                {
                    Datas = guncellenenRisk,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminRiskVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        public GeneralReturnType<AdminRiskVM> GetRiskByID(int id)
        {
            return new GeneralReturnType<AdminRiskVM>()
            {
                Datas = riskDAL.GetRiskByID(id),
                Message = "Success",
                StatusCode = 200
            };
        }
    }
}
