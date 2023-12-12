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
    public class KullaniciListesiBLL
    {
        KullaniciListesiDAL kullaniciListesiDal = new KullaniciListesiDAL();
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        public List<KullaniciListesiVM> kullaniciListesiGetir(Guid KullanicID,int tipID,bool urunMu)
        {

            return kullaniciListesiDal.KullaniciListesiGetir(KullanicID,tipID,urunMu);
        }

        public List<KullaniciListesiVM> ListeTipineGoreListeleriniGetir(Guid KullanicID, int tipID,bool aktifMi)
        {
            return new KullaniciListesiDAL().ListeTipineGoreKullanicininListeleriniGetir(gelenUser.Datas.ID, tipID, aktifMi);
        }

        public GeneralReturnType<KullaniciListesiVM> KullaniciListesiOlustur(KullaniciListesiVM kullaniciListesiVM)
        {
            var gelen = new KullaniciListesiDAL().ListeTipineGoreKullanicininListeleriniGetir(gelenUser.Datas.ID, kullaniciListesiVM.ListeTipiID,kullaniciListesiVM.AktifMi);
            foreach (var item in gelen)
            {
                if (item.ListeAdi==kullaniciListesiVM.ListeAdi)
                {
                    return new GeneralReturnType<KullaniciListesiVM>() { Datas=null,Message="Böyle bir liste zaten var",StatusCode=400};
                }
            }

            EFRepo<KullaniciListesi> efRepo = new EFRepo<KullaniciListesi>();
            var gelenKullaniciListesi = efRepo.Add(new KullaniciListesi() {ID=kullaniciListesiVM.ID,ListeAdi=kullaniciListesiVM.ListeAdi,KullaniciRolID=kullaniciListesiVM.KullaniciRolID,ListeTipiID=kullaniciListesiVM.ListeTipiID,AktifMi=kullaniciListesiVM.AktifMi});

            if (gelenKullaniciListesi==null)
            {
                return new GeneralReturnType<KullaniciListesiVM>() { Datas = null };
            }

            return new GeneralReturnType<KullaniciListesiVM>() {Datas=new KullaniciListesiVM() { ID=gelenKullaniciListesi.ID,ListeAdi=gelenKullaniciListesi.ListeAdi,KullaniciRolID=(Guid)gelenKullaniciListesi.KullaniciRolID,ListeTipiID=(int)gelenKullaniciListesi.ListeTipiID,AktifMi=(bool)gelenKullaniciListesi.AktifMi} };
        }
        public GeneralReturnType<KullaniciListesiVM> KullaniciListesiSil(KullaniciListesiVM kullaniciListesiVM)
        {
            GeneralReturnType<KullaniciListesiVM> returns = new GeneralReturnType<KullaniciListesiVM>();
            EFRepo<KullaniciListesi> eFRepo = new EFRepo<KullaniciListesi>();
            var silinenListe = eFRepo.SoftDelete(new KullaniciListesi() { ID=kullaniciListesiVM.ID,ListeAdi=kullaniciListesiVM.ListeAdi,KullaniciRolID=kullaniciListesiVM.KullaniciRolID,ListeTipiID=kullaniciListesiVM.ListeTipiID,AktifMi=kullaniciListesiVM.AktifMi});
            if (silinenListe==null)
            {
                returns.Datas = null;
                returns.Message = "silme işlemi başarısız";
                returns.StatusCode = 400;
            }
            else
            {
                returns.Datas = new KullaniciListesiVM() { ID = silinenListe.ID, ListeAdi = silinenListe.ListeAdi, ListeTipiID = (int)silinenListe.ListeTipiID, KullaniciRolID = (Guid)silinenListe.KullaniciRolID, AktifMi = (bool)silinenListe.AktifMi };
                returns.Message = "silme işlemi başarılı";
                returns.StatusCode = 200;
            }
            return returns;
        }
        public GeneralReturnType<KullaniciListesiVM> KullaniciListesiGuncelle(KullaniciListesiVM kullaniciListesiVM)
        {
            GeneralReturnType<KullaniciListesiVM> returns = new GeneralReturnType<KullaniciListesiVM>();
            var gelen = new KullaniciListesiDAL().ListeTipineGoreKullanicininListeleriniGetir(gelenUser.Datas.ID, kullaniciListesiVM.ListeTipiID, kullaniciListesiVM.AktifMi);
            foreach (var item in gelen)
            {
                if (item.ListeAdi == kullaniciListesiVM.ListeAdi)
                {
                    return new GeneralReturnType<KullaniciListesiVM>() { Datas = null, Message = "Böyle bir liste zaten var", StatusCode = 400 };
                }
            }

            EFRepo<KullaniciListesi> eFRepo = new EFRepo<KullaniciListesi>();
            var guncellenenListe = eFRepo.Update(new KullaniciListesi() { ID=kullaniciListesiVM.ID,ListeAdi=kullaniciListesiVM.ListeAdi,KullaniciRolID=kullaniciListesiVM.KullaniciRolID,ListeTipiID=kullaniciListesiVM.ListeTipiID,AktifMi=kullaniciListesiVM.AktifMi});

            if (guncellenenListe==null)
            {
                returns.Datas = null;
                returns.Message = "Guncelleme işlemi başarısız";
                returns.StatusCode = 400;
            }
            else
            {
                returns.Datas = new KullaniciListesiVM() { ID = guncellenenListe.ID, ListeAdi = guncellenenListe.ListeAdi, ListeTipiID = (int)guncellenenListe.ListeTipiID, AktifMi = (bool)guncellenenListe.AktifMi, KullaniciRolID = (Guid)guncellenenListe.KullaniciRolID };
                returns.Message = "guncelleme işlemi başarılı";
                returns.StatusCode = 200;
            }
            return returns;
        }
    }
}
