using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.VM.AdminVMs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.AdminLogicsDAL
{
    public class AdminUrunOnayDAL
    {
        public List<AdminUrunOnayVM> GetAll()
        {
            List<AdminUrunOnayVM> liste = null;
            using (Model1 db = new Model1())
            {
                liste = (from uo in db.UrunOnay
                                               join kr in db.KullaniciRolu on uo.EkleyenKullaniciRolID equals kr.ID
                                               join k in db.Kullanici on kr.KullaniciID equals k.ID
                                               join kri in db.KullaniciRolu on uo.InceleyenKullaniciRolID equals kri.ID
                                               join ki in db.Kullanici on kri.KullaniciID equals ki.ID
                                               join u in db.Urun on uo.UrunID equals u.ID
                                               select new AdminUrunOnayVM()
                                               {
                                                   ID = uo.ID,
                                                   TakipNumarasi = uo.TakipNumarasi,
                                                   OnayDurumu = (bool)uo.OnayDurumu,
                                                   KullaniciGozukmeDurumu = (bool)uo.KullaniciGozukmeDurumu,
                                                   IncelemeZamani = uo.IncelemeZamani,
                                                   EkleyenKullaniciMail = k.Email,
                                                   InceleyenKullaniciMail = ki.Email,
                                                   UrunAdi = u.UrunAdi
                                               }).ToList();
            }
            return liste;
        }
        public List<AdminUrunOnayVM> GetAllWithTakipNo(string takipNo)
        {
            List<AdminUrunOnayVM> liste = null;
            using (Model1 db = new Model1())
            {
                liste = (from uo in db.UrunOnay
                         join kr in db.KullaniciRolu on uo.EkleyenKullaniciRolID equals kr.ID
                         join k in db.Kullanici on kr.KullaniciID equals k.ID
                         join kri in db.KullaniciRolu on uo.InceleyenKullaniciRolID equals kri.ID
                         join ki in db.Kullanici on kri.KullaniciID equals ki.ID
                         join u in db.Urun on uo.UrunID equals u.ID
                         where uo.TakipNumarasi.Contains(takipNo)
                         select new AdminUrunOnayVM()
                         {
                             ID = uo.ID,
                             TakipNumarasi = uo.TakipNumarasi,
                             OnayDurumu = uo.OnayDurumu,
                             KullaniciGozukmeDurumu = (bool)uo.KullaniciGozukmeDurumu,
                             IncelemeZamani = uo.IncelemeZamani,
                             EkleyenKullaniciMail = k.Email,
                             InceleyenKullaniciMail = ki.Email,
                             UrunAdi = u.UrunAdi
                         }).ToList();
            }
            return liste;
        }
        public AdminUrunVM GetUrunWithName(string name)
        {
            Model1 db = new Model1();
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminUrunVM, Urun>((from urun in db.Urun
                                                  where urun.UrunAdi == name
                                                  select urun).FirstOrDefault());
        }
        public bool UpdateUrun(AdminUrunOnayVM adminUrunOnayVM)
        {
            bool control = false;
            UrunOnay guncellenecek = null;
            using (Model1 db = new Model1())
            {

                try
                {
                    guncellenecek = db.UrunOnay.Find(adminUrunOnayVM.ID);
                    guncellenecek.OnayDurumu = adminUrunOnayVM.OnayDurumu;
                    guncellenecek.InceleyenKullaniciRolID = ((from kr in db.KullaniciRolu
                                                              join k in db.Kullanici on kr.KullaniciID equals k.ID
                                                              where k.Email == adminUrunOnayVM.InceleyenKullaniciMail
                                                              select kr).FirstOrDefault()).ID;
                    guncellenecek.IncelemeZamani = adminUrunOnayVM.IncelemeZamani;
                    
                    control = true;
                }
                catch (Exception ex)
                {
                    control = false;
                }
            }
            new EFRepo<UrunOnay>().Update(guncellenecek);
            return guncellenecek == null ? false:true;
        }
    }
}
