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
    public class AdminSayfaBLL
    {
        AdminSayfaDAL _sayfaDAL = new AdminSayfaDAL();
        public AdminSayfaBLL()
        {

        }
        public GeneralReturnType<List<AdminSayfaVM>> GetAll()
        {
            try
            {
                return new GeneralReturnType<List<AdminSayfaVM>>()
                {
                    Datas = _sayfaDAL.GetAll(),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminSayfaVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }

        public GeneralReturnType<List<AdminSayfaVM>> GetSayfalarWithName(string name)
        {
            try
            {
                return new GeneralReturnType<List<AdminSayfaVM>>()
                {
                    Datas = _sayfaDAL.GetSayfalarWithName(name),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminSayfaVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminSayfaVM> Add(AdminSayfaVM adminSayfaVM)
        {
            try
            {
                return new GeneralReturnType<AdminSayfaVM>()
                {
                    Datas = _sayfaDAL.Add(adminSayfaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminSayfaVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminSayfaVM> Delete(AdminSayfaVM adminSayfaVM)
        {
            try
            {
                return new GeneralReturnType<AdminSayfaVM>()
                {
                    Datas = _sayfaDAL.Delete(adminSayfaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminSayfaVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminSayfaVM> Update(AdminSayfaVM adminSayfaVM)
        {
            try
            {
                return new GeneralReturnType<AdminSayfaVM>()
                {
                    Datas = _sayfaDAL.Update(adminSayfaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminSayfaVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
    }
}
