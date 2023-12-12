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
    public class AdminRolBLL
    {
        AdminRolDAL _rolDAL = new AdminRolDAL();

        public GeneralReturnType<List<AdminRolVM>> GetAll()
        {
            try
            {
                return new GeneralReturnType<List<AdminRolVM>>()
                {
                    Datas = _rolDAL.GetAll(),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminRolVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<List<AdminRolVM>> GetAllWithoutDeleted()
        {
            try
            {
                return new GeneralReturnType<List<AdminRolVM>>()
                {
                    Datas = _rolDAL.GetListWithoutDeleted(),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminRolVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminRolVM> Add(AdminRolVM adminRolVM)
        {
            try
            {
                return new GeneralReturnType<AdminRolVM>()
                {
                    Datas = _rolDAL.Add(adminRolVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminRolVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminRolVM> Delete(AdminRolVM adminRolVM)
        {
            try
            {
                return new GeneralReturnType<AdminRolVM>()
                {
                    Datas = _rolDAL.HardDelete(adminRolVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminRolVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        public GeneralReturnType<AdminRolVM> Update(AdminRolVM adminRolVM)
        {
            try
            {
                return new GeneralReturnType<AdminRolVM>()
                {
                    Datas = _rolDAL.Update(adminRolVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminRolVM>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }

    }
}
