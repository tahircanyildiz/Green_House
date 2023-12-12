using ExceptionHandling;
using GreenHouse.BLL.UsersBLL;
using GreenHouse.Core.Common;
using GreenHouse.DAL.AdminLogicsDAL;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.AdminVMs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.AdminsBLL
{
    public class AdminKategoriBLL
    {
        AdminKategoriDAL urunKategoriDAL;
        public AdminKategoriBLL()
        {
            urunKategoriDAL = new AdminKategoriDAL();
        }

        #region UrunGetList
        public GeneralReturnType<List<AdminKategoriVM>> GetList()
        {
            List<AdminKategoriVM> returnData = null;
            try
            {

                returnData = urunKategoriDAL.Get();

                return new GeneralReturnType<List<AdminKategoriVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminKategoriVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        public GeneralReturnType<AdminKategoriVM> GetKategoriByID(int ID)
        {
            return new GeneralReturnType<AdminKategoriVM>()
            {
                Datas = urunKategoriDAL.GetKategoriByID(ID),
                Message = "Success",
                StatusCode = 200
            };
        }

        public GeneralReturnType<List<AdminKategoriVM>> AltKategorileriGetir(int id)
        {
            return new GeneralReturnType<List<AdminKategoriVM>>()
            {
                Datas = urunKategoriDAL.GetAltKategoriLerByUstKategori(id),
                Message = "Success",
                StatusCode = 200
            };
        }
        public GeneralReturnType<List<AdminKategoriVM>> AltKategorileriGetir()
        {
            List<AdminKategoriVM> returnData = null;
            try
            {

                returnData = urunKategoriDAL.AltKategorileriGetir();

                return new GeneralReturnType<List<AdminKategoriVM>>()
                {
                    Datas = returnData,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminKategoriVM>>()
                {
                    Datas = returnData,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        #region UrunAdd
        public GeneralReturnType<AdminKategoriVM> Add(AdminKategoriVM AdminKategoriVM)
        {
            try
            {//////////////////////////////////////////////
                if (!Extensions.SqlControl(AdminKategoriVM.KategoriAdi) ||
                    !Extensions.SpaceOrNull(AdminKategoriVM.KategoriAdi))
                {
                    throw new Exception("Hatali ya da Eksik Giriş Yapıldı.");
                }

                AdminKategoriVM eklenenKategori = urunKategoriDAL.Add(AdminKategoriVM);
                if (eklenenKategori == null)
                {
                    throw new Exception("Kategori Eklenemedi.");
                }
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = eklenenKategori,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (BilesenEklenemediException ex)
            {
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 401
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        #region UrunHardDelete
        public GeneralReturnType<AdminKategoriVM> HardDelete(AdminKategoriVM AdminKategoriVM)
        {
            try
            {
                AdminKategoriVM silinenKategori = urunKategoriDAL.HardDelete(AdminKategoriVM);

                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = silinenKategori,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion



        #region UrunSoftDelete
        public GeneralReturnType<AdminKategoriVM> SoftDelete(AdminKategoriVM AdminKategoriVM)
        {
            try
            {
                AdminKategoriVM silinenKategori = urunKategoriDAL.SoftDelete(AdminKategoriVM);
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = silinenKategori,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        #region UrunUpdate
        public GeneralReturnType<AdminKategoriVM> Update(AdminKategoriVM AdminKategoriVM)
        {
            try
            {
                AdminKategoriVM guncellenenKategori = urunKategoriDAL.Update(AdminKategoriVM);
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = guncellenenKategori,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }
        #endregion

        public GeneralReturnType<AdminKategoriVM> GetUstKategoriByID(int id)
        {
            return new GeneralReturnType<AdminKategoriVM>()
            {
                Datas = urunKategoriDAL.GetUstKategoriByID(id),
                Message = "Success",
                StatusCode = 200
            };
        }

        public GeneralReturnType<List<AdminKategoriVM>> UstKategoriler()
        {
            return new GeneralReturnType<List<AdminKategoriVM>>()
            {
                Datas = urunKategoriDAL.Get(),
                Message = "Success",
                StatusCode = 200
            };
        }

        public GeneralReturnType<AdminKategoriVM> UstKategory(AdminKategoriVM AdminKategoriVM)
        {
            try
            {
                if (!Extensions.SqlControl(AdminKategoriVM.KategoriAdi) ||
                    !Extensions.SpaceOrNull(AdminKategoriVM.KategoriAdi))
                {
                    throw new Exception("Hatali ya da Eksik Giriş Yapıldı.");
                }

                AdminKategoriVM eklenenKategori = urunKategoriDAL.AddUstKategori(AdminKategoriVM);
                if (eklenenKategori == null)
                {
                    throw new Exception("Kategori Eklenemedi.");
                }
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = eklenenKategori,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (BilesenEklenemediException ex)
            {
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 401
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<AdminKategoriVM>()
                {
                    Datas = null,
                    Message = ex.Message,
                    StatusCode = 400
                };
            }
        }

        public GeneralReturnType<List<AdminKategoriVM>> GetKategorilerWithName(string name)
        {
            try
            {
                return new GeneralReturnType<List<AdminKategoriVM>>()
                {
                    Datas = urunKategoriDAL.GetKategorilerWithName(name),
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new GeneralReturnType<List<AdminKategoriVM>>()
                {
                    Datas = null,
                    StatusCode = 400,
                    Message = ex.Message
                };
            }
        }

    }
}

