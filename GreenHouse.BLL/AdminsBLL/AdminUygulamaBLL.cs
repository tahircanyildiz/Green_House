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
    public class AdminUygulamaBLL
    {
        AdminUygulamaDAL _uygulamaDal = new AdminUygulamaDAL();
        public AdminUygulamaBLL()
        {

        }
        public GeneralReturnType<List<AdminUygulamaVM>> GetAll()
        {
            try
            {
                return new GeneralReturnType<List<AdminUygulamaVM>>()
                {
                    Datas = _uygulamaDal.GetAll(),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminUygulamaVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<List<AdminUygulamaVM>> GetAllAktif()
        {
            try
            {
                return new GeneralReturnType<List<AdminUygulamaVM>>()
                {
                    Datas = _uygulamaDal.GetAllAktif(),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminUygulamaVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<List<AdminUygulamaVM>> GetYetkilerWithName(string name)
        {
            try
            {
                return new GeneralReturnType<List<AdminUygulamaVM>>()
                {
                    Datas = _uygulamaDal.GetUygulamaWithName(name),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminUygulamaVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }

        public GeneralReturnType<AdminUygulamaVM> Add(AdminUygulamaVM adminUygulamaVM)
        {
            try
            {
                return new GeneralReturnType<AdminUygulamaVM>()
                {
                    Datas = _uygulamaDal.Add(adminUygulamaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminUygulamaVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminUygulamaVM> Delete(AdminUygulamaVM adminUygulamaVM)
        {
            try
            {
                return new GeneralReturnType<AdminUygulamaVM>()
                {
                    Datas = _uygulamaDal.Delete(adminUygulamaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminUygulamaVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminUygulamaVM> Update(AdminUygulamaVM adminUygulamaVM)
        {
            try
            {
                return new GeneralReturnType<AdminUygulamaVM>()
                {
                    Datas = _uygulamaDal.Update(adminUygulamaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminUygulamaVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
    }
}
