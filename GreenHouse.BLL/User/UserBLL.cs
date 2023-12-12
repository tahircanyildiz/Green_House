
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicDAL;
using GreenHouse.VM.User;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenHouse.DAL;
using EfDeneme.DAL.Concrete;
using GreenHouse.BLL.KullaniciRol;
using GreenHouse.VM.VM;
using System.Net.Mail;

namespace GreenHouse.BLL.User
{
    public class UserBLL
    {
        public GeneralReturnType<KullaniciSelectVM> EmailaGoreKullaniciGetir(string email)
        {
            GeneralReturnType<KullaniciSelectVM> returns = new GeneralReturnType<KullaniciSelectVM>();
            EFRepo<Kullanici> eFRepo = new EFRepo<Kullanici>();
            Kullanici kullanici = eFRepo.SelectOne(k=>k.Email==email);
            if (kullanici==null)
            {
                returns.Datas = null;
                returns.Message = "Bu mailde bir kullanici yok";
                returns.StatusCode = 400;
            }
            else
            {
                returns.Datas = new KullaniciSelectVM() {ID=kullanici.ID,Adi=kullanici.Adi,Soyadi=kullanici.Soyadi,Email=kullanici.Email,EmailOnaylandiMi=(bool)kullanici.EmailOnayliMi,PasswordHash=kullanici.PasswordHash,AktifMi=(bool)kullanici.AktifMi };
                returns.Message = "Bu mailde bir kullanici yok";
                returns.StatusCode = 400;
            }
            return returns;
            
        }


        public GeneralReturnType<GirisYapKullaniciVM> GirisYap(string email, string password)
        {
            UserDAL userDAL = new UserDAL();
            var gelenveri = userDAL.GirisYap(email, password);
            return gelenveri;
        }
        public GeneralReturnType<PasswordResetVM> PasswordReset(PasswordResetVM kullanici)
        {
            Kullanici guncellenenDeger = null;
            EFRepo<Kullanici> kullaniciDal = new EFRepo<Kullanici>();
            Kullanici user = kullaniciDal.SelectOneById(k => k.ID == kullanici.ID);
            GeneralReturnType<PasswordResetVM> returns = new GeneralReturnType<PasswordResetVM>();
            if (user == null)
            {
                // ekranin degismesi ve email gibi diger filterlar eklenmeli
                returns.Datas = null;
                returns.Message = "Kullanıcı Bulunamadı";
                returns.StatusCode = 200;
            }
            else if (user.PasswordHash == kullanici.OldPassword)
            {
                kullaniciDal.Detach(user);
                guncellenenDeger = kullaniciDal.Update(new Kullanici() {ID=kullanici.ID, PasswordHash = kullanici.NewPassword,Email=user.Email,AktifMi=user.AktifMi,Adi=user.Adi,Soyadi=user.Soyadi,OlusturulmaTarihi=user.OlusturulmaTarihi,DegistirenKullaniciRolID=user.DegistirenKullaniciRolID,DegistirilmeTarihi=user.DegistirilmeTarihi,EmailOnayliMi=user.EmailOnayliMi,KullaniciRolu=user.KullaniciRolu,OlusturanKullaniciRolID=user.OlusturanKullaniciRolID });

                returns.Datas = new PasswordResetVM() { ID = guncellenenDeger.ID, Name = guncellenenDeger.Adi, Surname = guncellenenDeger.Soyadi, NewPassword = guncellenenDeger.PasswordHash };
                returns.Message = "Basarili";
                returns.StatusCode = 200;

            }
            else
            {
                returns.Datas = null;
                returns.Message = "Eski Şifre Hatalı";
                returns.StatusCode = 400;
            }

            return returns;
        }

        public GeneralReturnType<EmailResetVM> EmailReset(EmailResetVM reset)
        {   // email reset olduktan sonra email onaylanma mekanizması olmalı
            Kullanici guncellenenKullanici;
            GeneralReturnType<EmailResetVM> returns = new GeneralReturnType<EmailResetVM>();

            EFRepo<Kullanici> userDAL = new EFRepo<Kullanici>();
            try
            {
                var kullanici = userDAL.SelectOneById(k => k.ID == reset.ID);

                if (kullanici == null)
                {
                    returns.Datas = null;
                    returns.Message = "Boyle bir kullanıcı yok";
                    returns.StatusCode = 400;
                }
                else if (kullanici.Email == reset.OldEmail && kullanici.PasswordHash==reset.Password )
                {
                    try
                    {
                        userDAL.Detach(kullanici);
                        guncellenenKullanici = userDAL.Update(new Kullanici() { ID = reset.ID, Email = reset.NewEmail,PasswordHash=kullanici.PasswordHash, AktifMi = kullanici.AktifMi, Adi = kullanici.Adi, Soyadi = kullanici.Soyadi, OlusturulmaTarihi = kullanici.OlusturulmaTarihi, DegistirenKullaniciRolID = kullanici.DegistirenKullaniciRolID, DegistirilmeTarihi = kullanici.DegistirilmeTarihi, EmailOnayliMi = kullanici.EmailOnayliMi, KullaniciRolu = kullanici.KullaniciRolu, OlusturanKullaniciRolID = kullanici.OlusturanKullaniciRolID });
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    returns.Datas = new EmailResetVM() { ID = guncellenenKullanici.ID, Name = guncellenenKullanici.Adi, Surnama = guncellenenKullanici.Soyadi, NewEmail = guncellenenKullanici.Email };
                    returns.Message = "Başarılı";
                    returns.StatusCode = 200;

                }
                else
                {
                    returns.Datas = null;
                    returns.Message = "Eski email hatalı";
                    returns.StatusCode = 400;
                }
            }
            catch (Exception ex)
            {

                returns.Datas = null;
                returns.Message = "bilinmeyen bir hata alındı"+ex.Message;
                returns.StatusCode = 400;
            }
     
            return returns;

        }

        public GeneralReturnType<UserKayitVM> Add(UserKayitVM userKayitVM)
        {
            EFRepo<Kullanici> eFRepo = new EFRepo<Kullanici>();
            GeneralReturnType<UserKayitVM> retuns = new GeneralReturnType<UserKayitVM>();
            try
            {
                Kullanici eklenenKullanici = eFRepo.Add(new Kullanici() { ID = userKayitVM.ID, Adi = userKayitVM.Name, Email = userKayitVM.Email, PasswordHash = userKayitVM.Password, Soyadi = userKayitVM.Surname, AktifMi = userKayitVM.AktifMi, EmailOnayliMi = userKayitVM.EmailOnayliMi, OlusturulmaTarihi = DateTime.Now });
                if (eklenenKullanici!=null)
                {
                    KullaniciRoluBLL kullaniciRoluBLL = new KullaniciRoluBLL(eklenenKullanici);
                    var gelen = kullaniciRoluBLL.Add(new VM.KullaniciRolu.KullaniciRoluAddVM() { });
                    if (gelen.Datas!=null)
                    {
                        retuns.Datas = new UserKayitVM() { ID = eklenenKullanici.ID, AktifMi = (bool)eklenenKullanici.AktifMi, Email = eklenenKullanici.Email, EmailOnayliMi = (bool)eklenenKullanici.EmailOnayliMi, Name = eklenenKullanici.Adi, Surname = eklenenKullanici.Soyadi, Password = eklenenKullanici.PasswordHash };
                        retuns.Message = "Başarılı";
                        retuns.StatusCode = 400;
                    }
                    else
                    {
                        retuns.Datas = null;
                        retuns.Message = gelen.Message;
                        retuns.StatusCode = gelen.StatusCode;
                    }    
                }
                else if(DahaOnceKayitOlmusMu(userKayitVM.Email))
                {
                    retuns.Datas = null;
                    retuns.Message = "Böyle bir eposta zaten kullanımda";
                    retuns.StatusCode = 400;
                }
                else
                {
                    retuns.Datas = null;
                    retuns.Message = "Kullanıcı Eklenemedi";
                    retuns.StatusCode = 400;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return retuns;
        }

        public bool DahaOnceKayitOlmusMu(string email)
        {
            EFRepo<Kullanici> eFRepo = new EFRepo<Kullanici>();
            Kullanici kullanici = eFRepo.SelectOneById(k=>k.Email==email);
            bool deger = kullanici == null ? false : true;
            return deger;
        }
        public string RandomSifreOlustur()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
            Random random = new Random();

            char[] password = new char[8];

            for (int i = 0; i < 8; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);
        }
        public void KullaniciMailGonder(string kullaniciEposta,string mailKonu,string mailIcerik)
        {
            UserBLL userBLL = new UserBLL();
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("groonhauss@hotmail.com");
            ePosta.To.Add(kullaniciEposta); //göndereceğimiz mail adresi

            ePosta.Subject = mailKonu; //mail konusu
            ePosta.Body = mailIcerik; //mail içeriği 

            SmtpClient client = new SmtpClient("smtp.office365.com");
            client.Credentials = new System.Net.NetworkCredential("groonhauss@hotmail.com", "p123456789_");
            client.Port = 587;
            client.EnableSsl = true;
            client.Send(ePosta);
            object userState = true;
            bool kontrol = true;
            try
            {
                client.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
               
               
            }
            
        }
        public GeneralReturnType<KullaniciSelectVM> Update(KullaniciSelectVM kullaniciSelectVM)
        {
            GeneralReturnType<KullaniciSelectVM> returns = new GeneralReturnType<KullaniciSelectVM>();
            EFRepo<Kullanici> eFRepo = new EFRepo<Kullanici>();
            var guncellenenKullanici = eFRepo.Update(new Kullanici() { ID = kullaniciSelectVM.ID, Adi = kullaniciSelectVM.Adi, Soyadi = kullaniciSelectVM.Soyadi, Email = kullaniciSelectVM.Email, PasswordHash = kullaniciSelectVM.PasswordHash, EmailOnayliMi = kullaniciSelectVM.EmailOnaylandiMi,AktifMi=kullaniciSelectVM.AktifMi }) ;
            if (guncellenenKullanici==null)
            {
                returns.Datas = null;
                returns.Message = "Guncelleme Başarısız";
                returns.StatusCode = 400;
            }
            else
            {
                returns.Datas = new KullaniciSelectVM() { ID=guncellenenKullanici.ID,Adi=guncellenenKullanici.Adi,Email=guncellenenKullanici.Email,Soyadi=guncellenenKullanici.Soyadi,PasswordHash=guncellenenKullanici.PasswordHash,AktifMi=(bool)guncellenenKullanici.AktifMi,EmailOnaylandiMi=(bool)guncellenenKullanici.EmailOnayliMi};
                returns.Message = "Guncelleme Başarılı";
                returns.StatusCode = 400;
            }
            return returns;
        }

    }
}
