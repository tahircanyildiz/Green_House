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
    public class AdminYetkiBLL
    {
        AdminYetkiDAL _yetkiDAL = new AdminYetkiDAL();
        public AdminYetkiBLL()
        {

        }
        public GeneralReturnType<List<AdminYetkiVM>> GetAll()
        {
            try
            {
                return new GeneralReturnType<List<AdminYetkiVM>>()
                {
                    Datas = _yetkiDAL.GetAll(),
                    Message="Success",
                    StatusCode=200
                };
            }
            catch (Exception ex )
            {
                return new GeneralReturnType<List<AdminYetkiVM>>()
                {
                    Datas =null,
                    StatusCode=400,
                    Message=ex.Message
                };
            }
        }
        public GeneralReturnType<List<AdminYetkiVM>> GetYetkilerWithName(string name)
        {
            try
            {
                return new GeneralReturnType<List<AdminYetkiVM>>()
                {
                    Datas = _yetkiDAL.GetYetkilerWithName(name),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminYetkiVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminYetkiVM> Add(AdminYetkiVM adminYetkiVM)
        {
            try
            {
                return new GeneralReturnType<AdminYetkiVM>()
                {
                    Datas = _yetkiDAL.Add(adminYetkiVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminYetkiVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminYetkiVM> Delete(AdminYetkiVM adminYetkiVM)
        {
            try
            {
                return new GeneralReturnType<AdminYetkiVM>()
                {
                    Datas = _yetkiDAL.Delete(adminYetkiVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminYetkiVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminYetkiVM> Update(AdminYetkiVM adminYetkiVM)
        {
            try
            {
                return new GeneralReturnType<AdminYetkiVM>()
                {
                    Datas = _yetkiDAL.Update(adminYetkiVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminYetkiVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
    }
}
