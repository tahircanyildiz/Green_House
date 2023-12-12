using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.Core.Common;
using GreenHouse.VM.User;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class KullaniciListesiDAL
    {
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        public KullaniciListesiVM KullaniciListesiEkle(KullaniciListesiVM kullaniciListesiVM)
        {
            EFRepo<KullaniciListesi> kullaniciListesi = null;
            try
            {
                kullaniciListesi = new EFRepo<KullaniciListesi>(new Model1());
                MyMapper<KullaniciListesiVM, KullaniciListesi> mapper = new MyMapper<KullaniciListesiVM, KullaniciListesi>();
                KullaniciListesi kullanici = mapper.Map(kullaniciListesiVM);
                kullaniciListesi.Add(kullanici);
                return kullaniciListesiVM;
            }
            catch
            {
                kullaniciListesi = null;
                return null;
            }
        }
        public List<KullaniciListesiVM> KullaniciListesiGetir(Guid kullaniciID, int tipID, bool urunMu)
        {
            Model1 db = new Model1();

            List<KullaniciListesiVM> returnList = (from i in db.KullaniciListesi
                                                   join li in db.ListeIcerigi on i.ID equals li.ListeID
                                                   join tip in db.ListeTip on i.ListeTipiID equals tip.ID
                                                   join kullaniciRol in db.KullaniciRolu on i.KullaniciRolID equals kullaniciRol.ID
                                                   where kullaniciRol.KullaniciID == kullaniciID && tip.ID == tipID && li.UrunMu == urunMu
                                                   select new KullaniciListesiVM()
                                                   {
                                                       ID = i.ID,
                                                       ListeAdi = i.ListeAdi,
                                                       KullaniciRolID = (Guid)i.KullaniciRolID,
                                                       ListeTipiID = (int)i.ListeTipiID,

                                                   }).ToList();
            return returnList;
        }
        public List<KullaniciListesiVM> ListeTipineGoreKullanicininListeleriniGetir(Guid kullaniciID, int tipID,bool aktifMi)
        {
            Model1 db = new Model1();

            List<KullaniciListesiVM> returnList = (from kullistesi in db.KullaniciListesi
                                                   join kulrol in db.KullaniciRolu on kullistesi.KullaniciRolID equals kulrol.ID
                                                   where kulrol.KullaniciID == kullaniciID && kullistesi.ListeTipiID==tipID &&                      kullistesi.AktifMi==aktifMi
                                                   select new KullaniciListesiVM() { ID=kullistesi.ID,ListeAdi=kullistesi.ListeAdi,ListeTipiID=(int)kullistesi.ListeTipiID,KullaniciRolID= (Guid)kullistesi.KullaniciRolID}).ToList();
            return returnList;
        }

        public bool KullanicininKaraListesiVarMi()
        {
            Model1 db = new Model1();
            bool varMiVeri = db.KullaniciListesi
            .Join(db.KullaniciRolu, kl => kl.KullaniciRolID, kr => kr.ID, (kl, kr) => new { KullaniciListesi = kl, KullaniciRolu = kr })
            .Any(k => k.KullaniciRolu.ID == gelenUser.Datas.KullaniciRoluID && k.KullaniciListesi.ListeTipiID == 2);

            return varMiVeri;
        }


    }
}
