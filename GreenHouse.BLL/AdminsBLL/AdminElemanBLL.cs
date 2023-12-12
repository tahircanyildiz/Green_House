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
    public class AdminElemanBLL
    {
        AdminElemanDAL _elemanDAL = new AdminElemanDAL();
        public AdminElemanBLL()
        {

        }
        public GeneralReturnType<List<AdminElemanVM>> GetAll()
        {
            try
            {
                return new GeneralReturnType<List<AdminElemanVM>>()
                {
                    Datas = _elemanDAL.GetAll(),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminElemanVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<List<AdminElemanVM>> GetAllAktif()
        {
            try
            {
                return new GeneralReturnType<List<AdminElemanVM>>()
                {
                    Datas = _elemanDAL.GetAllAktif(),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminElemanVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }

        public GeneralReturnType<List<AdminElemanVM>> GetElemanlarWithName(string name)
        {
            try
            {
                return new GeneralReturnType<List<AdminElemanVM>>()
                {
                    Datas = _elemanDAL.GetElemanlarWithName(name),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminElemanVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }

        public GeneralReturnType<AdminElemanVM> Add(AdminElemanVM adminElemanVM)
        {
            try
            {
                return new GeneralReturnType<AdminElemanVM>()
                {
                    Datas = _elemanDAL.Add(adminElemanVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminElemanVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminElemanVM> Delete(AdminElemanVM adminElemanVM)
        {
            try
            {
                return new GeneralReturnType<AdminElemanVM>()
                {
                    Datas = _elemanDAL.Delete(adminElemanVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminElemanVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminElemanVM> Update(AdminElemanVM adminElemanVM)
        {
            try
            {
                return new GeneralReturnType<AdminElemanVM>()
                {
                    Datas = _elemanDAL.Update(adminElemanVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminElemanVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
    }
}
