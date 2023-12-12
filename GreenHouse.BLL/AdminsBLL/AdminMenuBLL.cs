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
    public class AdminMenuBLL
    {
        AdminMenuDAL _menuDAL = new AdminMenuDAL();
        public AdminMenuBLL()
        {

        }
        public GeneralReturnType<List<AdminMenuVM>> GetAll()
        {
            try
            {
                return new GeneralReturnType<List<AdminMenuVM>>()
                {
                    Datas = _menuDAL.GetAll(),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminMenuVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<List<AdminMenuVM>> GetMenulerWithName(string name)
        {
            try
            {
                return new GeneralReturnType<List<AdminMenuVM>>()
                {
                    Datas = _menuDAL.GetMenulerWithName(name),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminMenuVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminMenuVM> Add(AdminMenuVM adminMenuVM)
        {
            try
            {
                return new GeneralReturnType<AdminMenuVM>()
                {
                    Datas = _menuDAL.Add(adminMenuVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminMenuVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminMenuVM> Delete(AdminMenuVM adminMenuVM)
        {
            try
            {
                return new GeneralReturnType<AdminMenuVM>()
                {
                    Datas = _menuDAL.Delete(adminMenuVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminMenuVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminMenuVM> Update(AdminMenuVM adminMenuVM)
        {
            try
            {
                return new GeneralReturnType<AdminMenuVM>()
                {
                    Datas = _menuDAL.Update(adminMenuVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminMenuVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
    }
}
