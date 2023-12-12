using EfDeneme.DAL.Concrete;
using GreenHouse.Core.Common;
using GreenHouse.VM.KullaniciRolu;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.KullaniciRol
{
    public class KullaniciRoluBLL
    {
        Kullanici _eklenenKullanici;
        public KullaniciRoluBLL(Kullanici eklenenKullanici)
        {
            _eklenenKullanici = eklenenKullanici;
        }


        public GeneralReturnType<KullaniciRoluAddVM> Add(KullaniciRoluAddVM kullaniciRoluAddVM)
        {
            EFRepo<KullaniciRolu> krol = new EFRepo<KullaniciRolu>();
            //ekran lazım
            //krol.Add(new KullaniciRolu() { ID=kullaniciRoluAddVM.ID,KullaniciID=kullaniciRoluAddVM.KullaniciID,RolID=kullaniciRoluAddVM.RolID,RoleAtandigiZaman=kullaniciRoluAddVM.RoleAtandigiZaman,AktifMi=kullaniciRoluAddVM.AktifMi,OlusturulmaTarihi=kullaniciRoluAddVM.OlusturlmaTarihi,});
            GeneralReturnType<KullaniciRoluAddVM> generalReturnType = new GeneralReturnType<KullaniciRoluAddVM>();
            if (_eklenenKullanici==null)
            {
                generalReturnType.Datas = null;
                generalReturnType.Message = "Kullanici Eklenemediği için Kullanici rolu eklenemedi";
                generalReturnType.StatusCode = 400;
                return generalReturnType;
            }
            else
            {
                try
                {
                    KullaniciRolu eklenenKullaniciRolu = krol.Add(new KullaniciRolu() { ID = Guid.NewGuid(), KullaniciID = _eklenenKullanici.ID, RolID = 5, OlusturulmaTarihi = DateTime.Now, RoleAtandigiZaman = DateTime.Now, AktifMi = true });
                    if (eklenenKullaniciRolu != null)
                    {
                        generalReturnType.Datas = new KullaniciRoluAddVM() { ID = eklenenKullaniciRolu.ID, KullaniciID = (Guid)eklenenKullaniciRolu.KullaniciID, OlusturlmaTarihi = (DateTime)eklenenKullaniciRolu.OlusturulmaTarihi, AktifMi = (bool)eklenenKullaniciRolu.AktifMi, RolID = (int)eklenenKullaniciRolu.RolID, };
                        generalReturnType.Message = "başarılı";
                    }
                    else
                    {
                        generalReturnType.Datas = null;
                        generalReturnType.Message = "Kullanici rol tablosuna veri eklenemedi";
                        generalReturnType.StatusCode = 400;
                    }
                }
                catch (Exception)
                {
                    throw;
                }

            }
            return generalReturnType;
        }
    }
}
