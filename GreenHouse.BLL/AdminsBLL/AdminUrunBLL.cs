using ExceptionHandling;
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
    public class AdminUrunBLL
    {
        AdminUrunDAL adminUrunDAL;
        public AdminUrunBLL()
        {
            adminUrunDAL = new AdminUrunDAL();
        }
        public GeneralReturnType<AdminUrunVM> UrunEkleTransaction(AdminUrunVM adminUrunVM,List<AdminFirmaVM> firmalar,List<AdminBilesenVM> bilesenler, List<AdminResimVM> resimler)
        {
            GeneralReturnType<AdminUrunVM> generalReturnType = new GeneralReturnType<AdminUrunVM>();
            try
            {
                if (!Extensions.SqlControl(adminUrunVM.UrunAciklamasi, adminUrunVM.UrunAdi,adminUrunVM.BarkodNumarasi) ||
                   !Extensions.TextControl(adminUrunVM.UrunAciklamasi, adminUrunVM.UrunAdi, adminUrunVM.BarkodNumarasi)|| !Extensions.ControlNullOrWhiteSpaceAndLength(adminUrunVM.BarkodNumarasi,16))
                {
                    throw new Exception("Hatali ya da Eksik Giriş Yapıldı.");
                }
                generalReturnType.Datas = adminUrunDAL.UrunEkleTransaction(adminUrunVM, firmalar, bilesenler, resimler);
                if (generalReturnType.Datas ==null)
                {
                    generalReturnType.Message = "Urun Eklenirken Hata Olustu.";
                    generalReturnType.StatusCode = 405;
                    return generalReturnType;
                }
                generalReturnType.StatusCode = 200;
                generalReturnType.Message = "Success";
                return generalReturnType;
            }
            catch (Exception ex)
            {
                generalReturnType.Datas = null;
                generalReturnType.Message = ex.Message;
                generalReturnType.StatusCode = 400;
                return generalReturnType;
            }
        }
        public GeneralReturnType<AdminUrunVM> UrunGuncelleTransaction(AdminUrunVM adminUrunVM, List<AdminFirmaVM> firmalar, List<AdminBilesenVM> bilesenler, List<AdminResimVM> resimler)
        {
            GeneralReturnType<AdminUrunVM> generalReturnType = new GeneralReturnType<AdminUrunVM>();
            try
            {
                if (!Extensions.SqlControl(adminUrunVM.UrunAciklamasi, adminUrunVM.UrunAdi, adminUrunVM.BarkodNumarasi) ||
                   !Extensions.TextControl(adminUrunVM.UrunAciklamasi, adminUrunVM.UrunAdi, adminUrunVM.BarkodNumarasi) || !Extensions.ControlNullOrWhiteSpaceAndLength(adminUrunVM.BarkodNumarasi, 16))
                {
                    throw new Exception("Hatali ya da Eksik Giriş Yapıldı.");
                }
                generalReturnType.Datas = adminUrunDAL.UrunGuncelleTransaction(adminUrunVM, firmalar, bilesenler, resimler);
                if (generalReturnType.Datas == null)
                {
                    generalReturnType.Message = "Urun Guncellenirken Hata Olustu.";
                    generalReturnType.StatusCode = 405;
                    return generalReturnType;
                }
                generalReturnType.StatusCode = 200;
                generalReturnType.Message = "Success";
                return generalReturnType;
            }
            catch (Exception ex)
            {
                generalReturnType.Datas = null;
                generalReturnType.Message = ex.Message;
                generalReturnType.StatusCode = 400;
                return generalReturnType;
            }
        }

        public GeneralReturnType<AdminUrunVM> UrunSilTransaction(AdminUrunVM adminUrunVM, List<AdminFirmaVM> firmalar, List<AdminBilesenVM> bilesenler, List<AdminResimVM> resimler)
        {
            GeneralReturnType<AdminUrunVM> generalReturnType = new GeneralReturnType<AdminUrunVM>();
            try
            {
                generalReturnType.Datas = adminUrunDAL.UrunSilTransaction(adminUrunVM, firmalar, bilesenler, resimler);

                if (generalReturnType.Datas == null)
                {
                    generalReturnType.Message = "Urun Silinirken Hata Olustu.";
                    generalReturnType.StatusCode = 405;
                    return generalReturnType;
                }
                generalReturnType.StatusCode = 200;
                generalReturnType.Message = "Success";
                return generalReturnType;

            }
            catch (Exception ex)
            {
                generalReturnType.Datas = null;
                generalReturnType.Message = ex.Message;
                generalReturnType.StatusCode = 400;
                return generalReturnType;
            }
        }


        public GeneralReturnType<List<AdminUrunVM>> GetListAktifler()
        {
            List<AdminUrunVM> returnData = null;
            try
            {

                returnData = adminUrunDAL.GetAktifler();

                return new GeneralReturnType<List<AdminUrunVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminUrunVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #region UrunGetList
        public GeneralReturnType<List<AdminUrunVM>> GetList()
        {
            List<AdminUrunVM> returnData = null;
            try
            {

                returnData = adminUrunDAL.Get();

                return new GeneralReturnType<List<AdminUrunVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminUrunVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        } 
        #endregion

        #region UrunAdd
        public GeneralReturnType<AdminUrunVM> Add(AdminUrunVM adminUrunVM)
        {
            try
            {
                if (!Extensions.SqlControl(adminUrunVM.UrunAciklamasi, adminUrunVM.UrunAdi) || !Extensions.SpaceOrNull(adminUrunVM.UrunAciklamasi) || !Extensions.SpaceOrNull(adminUrunVM.UrunAdi))
                {
                    throw new Exception("Hatali ya da Eksik Giriş Yapıldı.");
                }

                AdminUrunVM eklenenUrun = adminUrunDAL.Add(adminUrunVM);
                if (eklenenUrun == null)
                {
                    throw new UrunEklenemediException("Urun Eklenemedi.");
                }
                return new GeneralReturnType<AdminUrunVM>()
                {
                    Datas = eklenenUrun,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (UrunEklenemediException ex)
            {
                return new GeneralReturnType<AdminUrunVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 401
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
        #endregion

        #region UrunHardDelete
        public GeneralReturnType<AdminUrunVM> HardDelete(AdminUrunVM adminUrunVM)
        {
            try
            {

                AdminUrunVM silinenUrun = adminUrunDAL.HardDelete(adminUrunVM);

                return new GeneralReturnType<AdminUrunVM>()
                {
                    Datas = silinenUrun,
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
        #endregion

        #region UrunSoftDelete
        public GeneralReturnType<AdminUrunVM> SoftDelete(AdminUrunVM adminUrunVM)
        {
            try
            {
                AdminUrunVM silinenUrun = adminUrunDAL.SoftDelete(adminUrunVM);
                return new GeneralReturnType<AdminUrunVM>()
                {
                    Datas = silinenUrun,
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
        #endregion

        #region UrunUpdate
        public GeneralReturnType<AdminUrunVM> Update(AdminUrunVM adminUrunVM)
        {
            try
            {
                AdminUrunVM guncellenenUrun = adminUrunDAL.Update(adminUrunVM);
                return new GeneralReturnType<AdminUrunVM>()
                {
                    Datas = guncellenenUrun,
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
        #endregion
    }
}
