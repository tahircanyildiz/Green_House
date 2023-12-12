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
    public class AdminResimBLL
    {
        AdminResimDAL _adminResimDAL = new AdminResimDAL();
        public AdminResimBLL()
        {

        }

        public GeneralReturnType<List<AdminResimVM>> GetResimlerWithUrunID(AdminUrunVM adminUrunVM)
        {
            try
            {

                return new GeneralReturnType<List<AdminResimVM>>()
                {
                    Datas = _adminResimDAL.GetResimlerWithUrunID(adminUrunVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminResimVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        public GeneralReturnType<AdminResimVM> Add(AdminResimVM adminResimVM)
        {
            try
            {
                return new GeneralReturnType<AdminResimVM>()
                {
                    Datas = _adminResimDAL.Add(adminResimVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminResimVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<AdminResimVM> Delete(AdminResimVM adminResimVM)
        {
            try
            {

                return new GeneralReturnType<AdminResimVM>()
                {
                    Datas = _adminResimDAL.Delete(adminResimVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminResimVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<AdminResimVM> Update(AdminResimVM adminResimVM)
        {
            try
            {

                return new GeneralReturnType<AdminResimVM>()
                {
                    Datas = _adminResimDAL.Update(adminResimVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminResimVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
    }
}
