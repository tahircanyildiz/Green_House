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
    public class AdminUrunIcerikBLL
    {
        AdminUrunIcerikDAL _urunIcerikDal = new AdminUrunIcerikDAL();
        public AdminUrunIcerikBLL()
        {

        }

        public GeneralReturnType<List<AdminBilesenVM>> GetBilesenListWithUrunID(AdminUrunVM adminUrunVM)
        {
            try
            {

                return new GeneralReturnType<List<AdminBilesenVM>>()
                {
                    Datas = _urunIcerikDal.GetBilesenListWithUrunID(adminUrunVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminBilesenVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<List<AdminUrunVM>> GetBilesenListWithUrunID(AdminBilesenVM bilesenVM)
        {
            try
            {
                return new GeneralReturnType<List<AdminUrunVM>>()
                {
                    Datas = _urunIcerikDal.GetUrunListWithBilesenID(bilesenVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminUrunVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        public GeneralReturnType<AdminUrunIcerikVM> Add(AdminUrunIcerikVM adminUrunIcerikVM)
        {
            try
            {

                return new GeneralReturnType<AdminUrunIcerikVM>()
                {
                    Datas = _urunIcerikDal.Add(adminUrunIcerikVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminUrunIcerikVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<AdminUrunIcerikVM> Delete(AdminUrunIcerikVM adminUrunIcerikVM)
        {
            try
            {

                return new GeneralReturnType<AdminUrunIcerikVM>()
                {
                    Datas = _urunIcerikDal.Delete(adminUrunIcerikVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminUrunIcerikVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
    }
}
