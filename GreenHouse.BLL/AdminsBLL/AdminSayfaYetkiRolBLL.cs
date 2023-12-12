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
    public class AdminSayfaYetkiRolBLL
    {
        AdminSayfaYetkiRolDAL _sayfaYetkiRolDAL = new AdminSayfaYetkiRolDAL();
        public GeneralReturnType<List<AdminRolVM>> GetRollerListWithSayfaID(AdminSayfaVM adminSayfaVM)
        {
            try
            {

                return new GeneralReturnType<List<AdminRolVM>>()
                {
                    Datas = _sayfaYetkiRolDAL.GetRollerListWithSayfaID(adminSayfaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminRolVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<List<AdminYetkiVM>> GetYetkilerWithSayfaRolID(AdminSayfaVM adminSayfaVM,AdminRolVM adminRolVM)
        {
            try
            {

                return new GeneralReturnType<List<AdminYetkiVM>>()
                {
                    Datas = _sayfaYetkiRolDAL.GetYetkilerWithSayfaRolID(adminSayfaVM,adminRolVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminYetkiVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
    }
}
