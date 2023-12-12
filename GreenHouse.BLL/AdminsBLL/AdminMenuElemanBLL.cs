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
    public class AdminMenuElemanBLL
    {
        AdminMenuElemanDAL _menuElemanDAL = new AdminMenuElemanDAL();
        public AdminMenuElemanBLL()
        {

        }
        public GeneralReturnType<List<AdminElemanVM>> GetElemanListWithMenuID(AdminMenuVM adminMenuVM)
        {
            try
            {

                return new GeneralReturnType<List<AdminElemanVM>>()
                {
                    Datas = _menuElemanDAL.GetElemanListWithMenuID(adminMenuVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminElemanVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<List<AdminMenuVM>> GetMenuListWithElemanID(AdminElemanVM adminElemanVM)
        {
            try
            {

                return new GeneralReturnType<List<AdminMenuVM>>()
                {
                    Datas = _menuElemanDAL.GetMenuListWithElemanID(adminElemanVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminMenuVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<AdminMenuElemanVM> Add(AdminMenuElemanVM adminMenuElemanVM)
        {
            try
            {

                return new GeneralReturnType<AdminMenuElemanVM>()
                {
                    Datas = _menuElemanDAL.Add(adminMenuElemanVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminMenuElemanVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<AdminMenuElemanVM> Delete(AdminMenuElemanVM adminMenuElemanVM)
        {
            try
            {

                return new GeneralReturnType<AdminMenuElemanVM>()
                {
                    Datas = _menuElemanDAL.Delete(adminMenuElemanVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminMenuElemanVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
    }
}
