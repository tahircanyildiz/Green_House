using GreenHouse.Core.Common;
using GreenHouse.DAL.AdminLogicsDAL;
using GreenHouse.VM.AdminVMs;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.AdminsBLL
{
    public class AdminUrunOnayBLL
    {
        AdminUrunOnayDAL _urunOnayDal = new AdminUrunOnayDAL();
        public AdminUrunOnayBLL()
        {

        }

        public GeneralReturnType<List<AdminUrunOnayVM>> GetAll()
        {
            try
            {
                return new GeneralReturnType<List<AdminUrunOnayVM>>()
                {
                    Datas = _urunOnayDal.GetAll(),
                    Message="Success",
                    StatusCode=200
                };
            }
            catch (Exception ex )
            {
                return new GeneralReturnType<List<AdminUrunOnayVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<List<AdminUrunOnayVM>> GetAllWithTakipNo(string takipNo)
        {
            try
            {
                return new GeneralReturnType<List<AdminUrunOnayVM>>()
                {
                    Datas = _urunOnayDal.GetAllWithTakipNo(takipNo),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminUrunOnayVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<AdminUrunVM> GetUrunWithName(string name)
        {
            try
            {
                return new GeneralReturnType<AdminUrunVM>()
                {
                    Datas = _urunOnayDal.GetUrunWithName(name),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminUrunVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public bool Update(AdminUrunOnayVM adminUrunOnayVM)
        {
            return _urunOnayDal.UpdateUrun(adminUrunOnayVM);
        }
        
    }
}
