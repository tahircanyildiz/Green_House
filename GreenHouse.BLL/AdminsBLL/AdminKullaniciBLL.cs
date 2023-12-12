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
    public class AdminKullaniciBLL
    {
        AdminKullaniciDAL kullaniciDAL;
        public AdminKullaniciBLL()
        {
            kullaniciDAL = new AdminKullaniciDAL();
        }

        #region Tüm Kullanıcılar
        public GeneralReturnType<List<AdminKullaniciVM>> GetAllUserList()
        {
            List<AdminKullaniciVM> returnData = null;
            try
            {

                returnData = kullaniciDAL.GetAll();

                return new GeneralReturnType<List<AdminKullaniciVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminKullaniciVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        #region Aktif kullanıcılar
        public GeneralReturnType<List<AdminKullaniciVM>> GetUserList()
        {
            List<AdminKullaniciVM> returnData = null;
            try
            {

                returnData = kullaniciDAL.GetAll();

                return new GeneralReturnType<List<AdminKullaniciVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminKullaniciVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        #region Maile göre Kullanıcı arama
        public GeneralReturnType<List<AdminKullaniciVM>> GetKullaniciWithMail(string mail)
        {
            try
            {
                return new GeneralReturnType<List<AdminKullaniciVM>>()
                {
                    Datas = kullaniciDAL.GetKullaniciWithMail(mail),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminKullaniciVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }
        #endregion

        #region Kullanıcı Silme
        public GeneralReturnType<AdminKullaniciVM> HardDelete(AdminKullaniciVM kullaniciVM)
        {
            try
            {

                AdminKullaniciVM silinenKullanici = kullaniciDAL.HardDelete(kullaniciVM);

                return new GeneralReturnType<AdminKullaniciVM>()
                {
                    Datas = silinenKullanici,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminKullaniciVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        #region Kullanıcı Pasifleştirme
        public GeneralReturnType<AdminKullaniciVM> SoftDelete(AdminKullaniciVM kullaniciVM)
        {
            try
            {
                AdminKullaniciVM silinenKullanici = kullaniciDAL.SoftDelete(kullaniciVM);
                return new GeneralReturnType<AdminKullaniciVM>()
                {
                    Datas = silinenKullanici,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminKullaniciVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        #region Kullanıcı Güncelleme
        public GeneralReturnType<AdminKullaniciVM> Update(AdminKullaniciVM kullaniciVM)
        {
            try
            {
                AdminKullaniciVM guncellenenKullanici = kullaniciDAL.Update(kullaniciVM);
                return new GeneralReturnType<AdminKullaniciVM>()
                {
                    Datas = guncellenenKullanici,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminKullaniciVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion


        //kullanici Listeleri
        #region Kullanıcının oluşturduğu listeler
        public GeneralReturnType<List<AdminKullaniciListesiVM>> KullaniciListeleriGetir(Guid id)
        {
            List<AdminKullaniciListesiVM> returnData = null;
            try
            {

                returnData = kullaniciDAL.KullaniciListeleriGetir(id);

                return new GeneralReturnType<List<AdminKullaniciListesiVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminKullaniciListesiVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        public GeneralReturnType<List<AdminListeIcerigiVM>> GetListeUrun(Guid id)
        {
            List<AdminListeIcerigiVM> returnData = null;
            try
            {
                returnData = kullaniciDAL.KulaniciListeUrunGetir(id);
                return new GeneralReturnType<List<AdminListeIcerigiVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminListeIcerigiVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        #region TümListeler
        public GeneralReturnType<List<AdminKullaniciVM>> GetUsersList()
        {
            List<AdminKullaniciVM> returnData = null;
            try
            {
                returnData = kullaniciDAL.Get();

                return new GeneralReturnType<List<AdminKullaniciVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminKullaniciVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        #region AktifListeler
        public GeneralReturnType<List<AdminKullaniciVM>> GetAllUsersList()
        {
            List<AdminKullaniciVM> returnData = null;
            try
            {

                returnData = kullaniciDAL.GetAll();

                return new GeneralReturnType<List<AdminKullaniciVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminKullaniciVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion


        #region ürün içerisindeki bileşenler
        public GeneralReturnType<List<AdminBilesenVM>> GetBilesenListWithUrunID(AdminUrunVM adminUrunVM)
        {
            try
            {
                AdminUrunIcerikDAL urunIcerikDal = new AdminUrunIcerikDAL();
                return new GeneralReturnType<List<AdminBilesenVM>>()
                {
                    Datas = urunIcerikDal.GetBilesenListWithUrunID(adminUrunVM),
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
        #endregion

        #region İçerik açıklama 
        public GeneralReturnType<AdminBilesenVM> UrunIcerikAciklama(Guid id)
        {
            AdminBilesenVM returnData = null;
            try
            {
                AdminBilesenDAL bilesenDal = new AdminBilesenDAL();
                returnData = bilesenDal.GetBilesenByID(id);
                return new GeneralReturnType<AdminBilesenVM>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminBilesenVM>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }

        }
        #endregion
    }


}
