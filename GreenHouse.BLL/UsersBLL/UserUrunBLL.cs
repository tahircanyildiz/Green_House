using EfDeneme.DAL.Concrete;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.User;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class UserUrunBLL
    {
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        UrunDAL urunDAL;
        public UserUrunBLL()
        {
            urunDAL = new UrunDAL();
        }

        public List<UrunVM> GetirBLL()
        {
            return urunDAL.Getir();
        }

        public List<UrunVM> KategoriIleGetirBLL(KategoriVM kategoriVM)
        {
            return urunDAL.KategoriIleGetir(kategoriVM);
        }

        public List<UrunVM> AdIleGetirBLL(string ad)
        {
            return urunDAL.AdIleGetir(ad);
        }

        public UrunVM EkleUrunBLL(UrunVM urunVM)
        {
            return urunDAL.EkleUrun(urunVM);
        }

        public UrunVM BarkodaGoreUrunGetir(string barkod)
        {
            return urunDAL.BarkodaGoreUrunGetir(barkod);
        }

        public UrunVM IDIleGetirBLL(Guid ID)
        {
            return urunDAL.IDIleGetir(ID);
        }
        public bool EkleUrunFirmaTransaction(UrunVM urunVM,params UrunFirmaVM[] urunFirmaVM)
        {
            return urunDAL.UrunFirmaEkleTransaction(urunVM, urunFirmaVM);
        }
        public bool EkleUrunBilesenTransaction(UrunVM urunVM,params UrunBilesenVM[] urunBilesenVM)
        {
            return urunDAL.UrunBilesenEkleTransaction(urunVM, urunBilesenVM);
        }
        public bool UrunFirmaEkleTransaction(UrunVM urunVM, List<FirmaVM> Firma, UrunOnayInsertVM urunOnayInsertVM, List<string> resimInsertVM)
        {
            return urunDAL.UrunFirmaEkleTransaction(urunVM, Firma, urunOnayInsertVM, resimInsertVM);
        }

        public bool UrunVarMi(string urunIsmi)
        {
            return urunDAL.UrunVarMi(urunIsmi);
        }

        public GeneralReturnType<List<Urun>> KullanicininEkledigiUrunler(Guid kullaniciRoluID)
        {
            GeneralReturnType<List<Urun>> returns = new GeneralReturnType<List<Urun>>();
            EFRepo<Urun> eFRepo = new EFRepo<Urun>();
            var gelen = eFRepo.SelectAll(u=>u.OlusturanKullaniciRolID== kullaniciRoluID);
            if (gelen==null)
            {
                returns.Datas = null;
                returns.Message = "Kullanıcı ürün girmemiş";
                returns.StatusCode = 400;
            }
            else
            {
                returns.Datas = gelen ;
                returns.Message = "";
                returns.StatusCode = 200;
            }
            return returns;
        }

    }
}
