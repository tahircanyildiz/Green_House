using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicDAL;
using GreenHouse.VM.User;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class ListeIcerikDAL
    {
        GirisYapKullaniciVM _girisYapanKullanici;

        public ListeIcerikDAL()
        {

        }
        public ListeIcerikDAL(GirisYapKullaniciVM girisYapKullanici)
        {
            _girisYapanKullanici = girisYapKullanici;
        }
        public List<ListeIcerikVM> ListeIcerikGetir(Guid kullaniciRolID, int listeTipi)
        {
            //return new EFRepo<ListeIcerigi>().SelectAllWithInclude(a => a.OlusturanKullaniciRolID == kullaniciRolID, "KullaniciListesi").Select(a => new ListeIcerikVM()
            //{
            //    ID = a.ID,
            //    ListeID = a.ListeID,
            //    UrunMu = (bool)a.UrunMu,
            //    IcerikID = a.IcerikID,
            //    OlusturulmaTarihi = (DateTime)a.OlusturulmaTarihi,
            //    DegistirenKullaniciRolID = (Guid)a.DegistirenKullaniciRolID,
            //    DegistirilmeTarihi = (DateTime)a.DegistirilmeTarihi
            //}).ToList();

            Model1 db = new Model1();

            List<ListeIcerikVM> returnList = (from i in db.ListeIcerigi
                                              join kl in db.KullaniciListesi on i.ListeID equals kl.ID
                                              join tip in db.ListeTip on kl.ListeTipiID equals tip.ID
                                              join urun in db.Urun on i.IcerikID equals urun.ID
                                              where kl.KullaniciRolID == kullaniciRolID && tip.ID == listeTipi
                                              select new ListeIcerikVM()
                                              {
                                                  ID = i.ID,
                                                  ListeID = i.ListeID,
                                                  UrunMu = (bool)i.UrunMu,
                                                  IcerikID = i.IcerikID,
                                                  UrunAdi=urun.UrunAdi
                                              }).ToList();
            return returnList;
        }

        public GeneralReturnType<List<ListeIcerikVM>> ListeTipineGoreBilesenGetir(Guid kullaniciRolID, int listeTipi)
        {
            Model1 db = new Model1();

            List<ListeIcerikVM> returnList = (from i in db.ListeIcerigi
                                              join kl in db.KullaniciListesi on i.ListeID equals kl.ID
                                              join tip in db.ListeTip on kl.ListeTipiID equals tip.ID
                                              join bilesen in db.Bilesen on i.IcerikID equals bilesen.ID
                                              where kl.KullaniciRolID == kullaniciRolID && tip.ID == listeTipi
                                              select new ListeIcerikVM()
                                              {
                                                  ID = i.ID,
                                                  ListeID = i.ListeID,
                                                  UrunMu = (bool)i.UrunMu,
                                                  IcerikID = i.IcerikID,
                                                  UrunAdi = bilesen.Adi
                                              }).ToList();
            return new GeneralReturnType<List<ListeIcerikVM>>() { Datas= returnList,Message="",StatusCode=200} ;
        }

        public bool ListeIcerikEkle(ListeIcerikVM listeIcerikVM)
        {
            EFRepo<ListeIcerigi> listeIcerigi = null;
            try
            {
                listeIcerigi = new EFRepo<ListeIcerigi>(new Model1());
                MyMapper<ListeIcerikVM, ListeIcerigi> mapper = new MyMapper<ListeIcerikVM, ListeIcerigi>();
                ListeIcerigi icerik = mapper.Map(listeIcerikVM);
                listeIcerigi.Add(icerik);
                return true;
            }
            catch
            {
                listeIcerigi = null;
                return false;
            }
        }

        public Guid KaraListeIDGetir()
        {
            Model1 db = new Model1();
            var gelen = (from kul in db.KullaniciListesi 
                         where kul.KullaniciRolID == _girisYapanKullanici.KullaniciRoluID && kul.ListeTipiID==2
                         select kul.ID
                         ).FirstOrDefault();

            return gelen;
        } 
        public List<ListeIcerikVM> FavoriListeGoreVeriGetir(Guid deger)
        {
            List<ListeIcerikVM> tumUrunBilesenListesi = new List<ListeIcerikVM>();
            Model1 db = new Model1();

            List<ListeIcerikVM> birlestirilmisListe = new List<ListeIcerikVM>();
            var gelenUrun = (from li in db.ListeIcerigi
                         join kl in db.KullaniciListesi on li.ListeID equals kl.ID
                         join urun in db.Urun on li.IcerikID equals urun.ID
                         where kl.ID==deger && li.UrunMu==true
                         select new ListeIcerikVM() {ID=li.ID,ListeID=li.ListeID,UrunMu=(bool)li.UrunMu,IcerikID=li.IcerikID,UrunAdi=urun.UrunAdi, }).ToList();

            var gelenBilesen = (from li in db.ListeIcerigi
                         join kl in db.KullaniciListesi on li.ListeID equals kl.ID
                         join Bilesen in db.Bilesen on li.IcerikID equals Bilesen.ID
                         where kl.ID == deger && li.UrunMu == false
                         select new ListeIcerikVM() { ID = li.ID, ListeID = li.ListeID, UrunMu = (bool)li.UrunMu, IcerikID = li.IcerikID, UrunAdi = Bilesen.Adi, }).ToList();

            tumUrunBilesenListesi.AddRange(gelenUrun);
            tumUrunBilesenListesi.AddRange(gelenBilesen);


            return tumUrunBilesenListesi;

        }


    }
}
