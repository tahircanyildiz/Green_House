using EfDeneme.DAL.Mapper;
//using ExceptionHandling;
using GreenHouse.Core.Common;
using GreenHouse.VM.User;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicDAL
{
    public class UserDAL
    {
        
        public GeneralReturnType<GirisYapKullaniciVM> GirisYap(string email, string password)
        {
            GirisYapKullaniciVM result;
            using (Model1 db = new Model1())
            {
                try
                {
                    result = (from kullanici in db.Kullanici
                              where kullanici.Email == email && kullanici.PasswordHash == password
                              join kullaniciRolu in db.KullaniciRolu on kullanici.ID equals kullaniciRolu.KullaniciID
                              select new GirisYapKullaniciVM
                              {
                                  ID=kullanici.ID,
                                  Name=kullanici.Adi,
                                  Surname=kullanici.Soyadi,
                                  CreatedDate=kullanici.OlusturulmaTarihi == null ? new DateTime(2000, 1, 1) : (DateTime)kullanici.OlusturulmaTarihi,
                                  Email = kullanici.Email,
                                  Password = kullanici.PasswordHash,
                                  KullaniciRolID = kullaniciRolu.RolID == null ? 0 : (int)kullaniciRolu.RolID,
                                  KullaniciRoluID = kullaniciRolu.ID
                              }).FirstOrDefault();
                    if (result==null)
                    {
                        //throw new KullaniciBulunamadiException("Kullanici bulunamadı");
                    }
                }
                catch (Exception)
                {

                    result=null;
                }
                
            }
            return new GeneralReturnType<GirisYapKullaniciVM>() { Datas=result, Message = "İslem Başarılı",StatusCode=200};
        }

        public List<UrunVM> KullanicininGiridigiUrunler(Guid ID)
        {
            Model1 db = new Model1();
            var sorgu = (from u in db.Urun
                         join kr in db.KullaniciRolu on u.OlusturanKullaniciRolID equals kr.ID
                         where kr.KullaniciID==ID
                         select new UrunVM() {ID=u.ID,BarkodNumarasi=u.BarkodNumarasi,UrunAdi=u.UrunAdi,KategoriID=(int)u.KategoriID,UrunAciklamasi=u.UrunAciklamasi} ).ToList();
            return sorgu;
        }
    }
}
