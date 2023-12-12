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
    public class AdminUrunFirmaBLL
    {
        AdminUrunFirmaDAL _urunFirmaDal = new AdminUrunFirmaDAL();
        public AdminUrunFirmaBLL()
        {

        }
        public GeneralReturnType<List<AdminUrunFirmaVM>> GetList()
        {
            List<AdminUrunFirmaVM> returnData = null;
            try
            {
                returnData = _urunFirmaDal.GetAll();

                return new GeneralReturnType<List<AdminUrunFirmaVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminUrunFirmaVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<List<AdminUrunVM>> GetUrunListWithFirmaID(AdminFirmaVM adminFirmaVM)
        {
            try
            {

                return new GeneralReturnType<List<AdminUrunVM>>()
                {
                    Datas = _urunFirmaDal.GetUrunListWithFirmaID(adminFirmaVM) ,
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
        public GeneralReturnType<List<AdminFirmaVM>> GetFirmaListWithUrunID(AdminUrunVM adminUrunVM)
        {
            try
            {

                return new GeneralReturnType<List<AdminFirmaVM>>()
                {
                    Datas = _urunFirmaDal.GetFirmaListWithUrunID(adminUrunVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminFirmaVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<AdminUrunFirmaVM> Delete(AdminUrunFirmaVM adminUrunFirmaVM)
        {
            try
            {

                return new GeneralReturnType<AdminUrunFirmaVM>()
                {
                    Datas = _urunFirmaDal.Delete(adminUrunFirmaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminUrunFirmaVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<AdminUrunFirmaVM> Add(AdminUrunFirmaVM adminUrunFirmaVM)
        {
            try
            {

                return new GeneralReturnType<AdminUrunFirmaVM>()
                {
                    Datas = _urunFirmaDal.Add(adminUrunFirmaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminUrunFirmaVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        //public void deneme(AdminUrunVM adminFirmaVM)
        //{
           
        //}
    }
}
