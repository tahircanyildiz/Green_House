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
    public class AdminFirmaBLL
    {
        AdminFirmaDAL _firmaDal;
        public AdminFirmaBLL()
        {
            _firmaDal = new AdminFirmaDAL();
        }

        #region Firma GetList
        public GeneralReturnType<List<AdminFirmaVM>> GetList()
        {
            List<AdminFirmaVM> returnData = null;
            try
            {

                returnData = _firmaDal.Get();

                return new GeneralReturnType<List<AdminFirmaVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminFirmaVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion


        public GeneralReturnType<List<AdminFirmaVM>> GetListWithName(string firmaAdi)
        {
            List<AdminFirmaVM> returnData = null;
            try
            {

                returnData = _firmaDal.GetWithName(firmaAdi);

                return new GeneralReturnType<List<AdminFirmaVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminFirmaVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #region FirmaAdd
        public GeneralReturnType<AdminFirmaVM> Add(AdminFirmaVM adminFirmaVM)
        {
            try
            {
                if (!Extensions.SqlControl(adminFirmaVM.FirmaAdi, adminFirmaVM.FirmaAdresi) || !Extensions.SpaceOrNull(adminFirmaVM.FirmaAdresi) || !Extensions.SpaceOrNull(adminFirmaVM.FirmaAdi))
                {
                    throw new Exception("Hatali ya da Eksik Giriş Yapıldı.");
                }
                AdminFirmaVM eklenen = _firmaDal.Add(adminFirmaVM);
                if (eklenen == null)
                {
                    throw new Exception("Urun Eklenemedi.");
                }
                return new GeneralReturnType<AdminFirmaVM>()
                {
                    Datas = eklenen,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminFirmaVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        } 
        #endregion

        #region FirmaUpdate
        public GeneralReturnType<AdminFirmaVM> Update(AdminFirmaVM adminFirmaVM)
        {
            try
            {
                return new GeneralReturnType<AdminFirmaVM>()
                {
                    Datas = _firmaDal.Update(adminFirmaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminFirmaVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        } 
        #endregion

        #region FirmaDelete
        public GeneralReturnType<AdminFirmaVM> Delete(AdminFirmaVM adminFirmaVM)
        {
            try
            {
                return new GeneralReturnType<AdminFirmaVM>()
                {
                    Datas = _firmaDal.HardDelete(adminFirmaVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminFirmaVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        } 
        #endregion
    }
}
