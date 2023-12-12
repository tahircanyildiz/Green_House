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
    public class AdminSayfaMenuBLL
    {
        AdminSayfaMenuDAL _sayfaMenuDAL = new AdminSayfaMenuDAL();
        public GeneralReturnType<List<AdminMenuVM>> GetMenulerListWithSayfaID(AdminSayfaVM adminSayfaVM)
        {
            try
            {

                return new GeneralReturnType<List<AdminMenuVM>>()
                {
                    Datas = _sayfaMenuDAL.GetMenulerListWithSayfaID(adminSayfaVM),
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
        public GeneralReturnType<List<AdminSayfaVM>> GetSayfalarListWithMenuID(AdminMenuVM adminMenuVM)
        {
            try
            {

                return new GeneralReturnType<List<AdminSayfaVM>>()
                {
                    Datas = _sayfaMenuDAL.GetSayfalarListWithMenuID(adminMenuVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminSayfaVM>>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        public GeneralReturnType<List<AdminMenuVM>> GetMenulerListWithSayfaAdi(string sayfaAdi)
        {
            try
            {

                return new GeneralReturnType<List<AdminMenuVM>>()
                {
                    Datas = _sayfaMenuDAL.GetMenulerListWithSayfaAdi(sayfaAdi),
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

        public GeneralReturnType<AdminSayfaMenuVM> Delete(AdminSayfaMenuVM adminSayfaMenuVM)
        {
            try
            {

                return new GeneralReturnType<AdminSayfaMenuVM>()
                {
                    Datas = _sayfaMenuDAL.Delete(adminSayfaMenuVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminSayfaMenuVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        public GeneralReturnType<AdminSayfaMenuVM> Add(AdminSayfaMenuVM adminSayfaMenuVM)
        {
            try
            {

                return new GeneralReturnType<AdminSayfaMenuVM>()
                {
                    Datas = _sayfaMenuDAL.Add(adminSayfaMenuVM),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminSayfaMenuVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
    }
}
