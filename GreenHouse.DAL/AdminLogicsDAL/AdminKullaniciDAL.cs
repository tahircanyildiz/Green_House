using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.VM.AdminVMs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.AdminLogicsDAL
{
    public class AdminKullaniciDAL
    {
        private MyEntityMapper mapper = new MyEntityMapper();
        //Kullanıcılar
        public List<AdminKullaniciVM> GetAll()
        {
            return mapper.Map<List<AdminKullaniciVM>, List<Kullanici>>(new EFRepo<Kullanici>().SelectAll());
        }
        public List<AdminKullaniciVM> Get()
        {
            return mapper.Map<List<AdminKullaniciVM>, List<Kullanici>>(new EFRepo<Kullanici>().SelectAll(x => x.AktifMi == true));
        }

        public AdminKullaniciVM HardDelete(AdminKullaniciVM kullaniciVM)
        {
            return mapper.Map<AdminKullaniciVM, Kullanici>(new EFRepo<Kullanici>().HardDelete(mapper.Map<Kullanici, AdminKullaniciVM>(kullaniciVM)));
        }
        public AdminKullaniciVM SoftDelete(AdminKullaniciVM kullaniciVM)
        {
            return mapper.Map<AdminKullaniciVM, Kullanici>(new EFRepo<Kullanici>().SoftDelete(mapper.Map<Kullanici, AdminKullaniciVM>(kullaniciVM)));
        }
        public AdminKullaniciVM Update(AdminKullaniciVM kullaniciVM)
        {
            return mapper.Map<AdminKullaniciVM, Kullanici>(new EFRepo<Kullanici>().Update(mapper.Map<Kullanici, AdminKullaniciVM>(kullaniciVM)));
        }
        public List<AdminKullaniciVM> GetKullaniciWithMail(string mail)
        {
            Model1 db = new Model1();
            List<Kullanici> liste = (from k in db.Kullanici
                                     where k.Email.Contains(mail)
                                     select k).ToList();
            return new MyEntityMapper().Map<List<AdminKullaniciVM>, List<Kullanici>>(liste);
        }

        //Kullanıcı Listeleri
        public List<AdminKullaniciListesiVM> KullaniciListeleriGetir(Guid id)
        {
            Model1 db = new Model1();
            List<KullaniciListesi> data = (from k in db.Kullanici
                                           join kr in db.KullaniciRolu on k.ID equals kr.KullaniciID
                                           join kl in db.KullaniciListesi on kr.ID equals kl.KullaniciRolID
                                           where k.ID == id
                                           select kl).ToList();
            return new MyEntityMapper().Map<List<AdminKullaniciListesiVM>, List<KullaniciListesi>>(data);
        }
        public List<AdminKullaniciVM> GetListAll()
        {
            return mapper.Map<List<AdminKullaniciVM>, List<Kullanici>>(new EFRepo<Kullanici>().SelectAll());
        }
        public List<AdminKullaniciVM> GetList()
        {
            return mapper.Map<List<AdminKullaniciVM>, List<Kullanici>>(new EFRepo<Kullanici>().SelectAll(x => x.AktifMi == true));
        }

        public List<AdminListeIcerigiVM> KulaniciListeUrunGetir(Guid id)
        {
            return mapper.Map<List<AdminListeIcerigiVM>, List<ListeIcerigi>>(new EFRepo<ListeIcerigi>().SelectAll(a => a.ListeID == id));
        }

        public List<AdminBilesenVM> GetBilesenListWithUrunID(AdminUrunVM adminUrunVM)
        {
            Model1 db = new Model1();

            List<AdminBilesenVM> returnList = (from b in db.Bilesen
                                               join bu in db.UrunIcerik on b.ID equals bu.BilesenID
                                               join u in db.Urun on bu.UrunID equals u.ID
                                               where u.ID == adminUrunVM.ID
                                               select new AdminBilesenVM()
                                               {
                                                   Adi = b.Adi,
                                                   ID = b.ID,
                                                   Aciklama = b.Aciklama,
                                                   AktifMi = b.AktifMi,
                                                   DegistirenKullaniciRolID = b.DegistirenKullaniciRolID,
                                                   DegistirilmeTarihi = b.DegistirilmeTarihi,
                                                   OlusturanKullaniciRolID = b.OlusturanKullaniciRolID,
                                                   OlusturulmaTarihi = b.OlusturulmaTarihi,
                                                   Risk = b.Risk,
                                                   RiskID = b.RiskID
                                               }).ToList();
            return returnList;
        }

        public AdminBilesenVM GetBilesenByID(Guid ID)
        {
            return new MyEntityMapper().Map<AdminBilesenVM, Bilesen>(new EFRepo<Bilesen>().SelectOneById(a => a.ID == ID));
        }




    }
}
