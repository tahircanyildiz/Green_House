using EfDeneme.DAL.Mapper;
using ExceptionHandling;
using GreenHouse.Core.Common;
using GreenHouse.DAL.AdminLogicsDAL;
using GreenHouse.VM.AdminVMs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.AdminsBLL
{
    public class AdminBilesenBLL
    {
        AdminBilesenDAL bilesenDAL;
        public AdminBilesenBLL()
        {
            bilesenDAL = new AdminBilesenDAL();
        }

        #region UrunGetList
        public GeneralReturnType<List<AdminBilesenVM>> GetList()
        {
            List<AdminBilesenVM> returnData = null;
            try
            {

                returnData = bilesenDAL.Get();

                return new GeneralReturnType<List<AdminBilesenVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminBilesenVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion


        public GeneralReturnType<List<AdminBilesenVM>> GetListWithName(string bilesenAdi)
        {
            List<AdminBilesenVM> returnData = null;
            try
            {

                returnData = bilesenDAL.GetWithName(bilesenAdi);

                return new GeneralReturnType<List<AdminBilesenVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminBilesenVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        #region UrunAdd
        public GeneralReturnType<AdminBilesenVM> Add(AdminBilesenVM bilesenVM)
        {
            try
            {
                if (!Extensions.SqlControl(bilesenVM.Adi, bilesenVM.Aciklama) ||
                    !Extensions.TextControl(bilesenVM.Adi, bilesenVM.Aciklama))
                {
                    throw new Exception("Hatali ya da Eksik Giriş Yapıldı.");
                }

                AdminBilesenVM eklenenBilesen = bilesenDAL.Add(bilesenVM);
                if (eklenenBilesen == null)
                {
                    throw new BilesenEklenemediException("Bileşen Eklenemedi.");
                }
                return new GeneralReturnType<AdminBilesenVM>()
                {
                    Datas = eklenenBilesen,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (BilesenEklenemediException ex)
            {
                return new GeneralReturnType<AdminBilesenVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 401
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminBilesenVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        #region UrunHardDelete
        public GeneralReturnType<AdminBilesenVM> HardDelete(AdminBilesenVM bilesenVM)
        {
            try
            {

                AdminBilesenVM silinenBilesen = bilesenDAL.HardDelete(bilesenVM);

                return new GeneralReturnType<AdminBilesenVM>()
                {
                    Datas = silinenBilesen,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminBilesenVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        #region UrunSoftDelete
        public GeneralReturnType<AdminBilesenVM> SoftDelete(AdminBilesenVM bilesenVM)
        {
            try
            {
                AdminBilesenVM silinenBilesen = bilesenDAL.SoftDelete(bilesenVM);
                return new GeneralReturnType<AdminBilesenVM>()
                {
                    Datas = silinenBilesen,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminBilesenVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        #region UrunUpdate
        public GeneralReturnType<AdminBilesenVM> Update(AdminBilesenVM bilesenVM)
        {
            try
            {
                AdminBilesenVM guncellenenBilesen = bilesenDAL.Update(bilesenVM);
                return new GeneralReturnType<AdminBilesenVM>()
                {
                    Datas = guncellenenBilesen,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminBilesenVM>()
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
