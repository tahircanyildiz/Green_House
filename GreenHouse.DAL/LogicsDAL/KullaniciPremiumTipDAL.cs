using EfDeneme.DAL.Concrete;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class KullaniciPremiumTipDAL
    {
        public List<KullaniciPremiumTipVM> GetirPremiumTip()
        {
            EFRepo<KullaniciTipi> DAL = new EFRepo<KullaniciTipi>(new Model1());
            return DAL.SelectAll().Select(a => new KullaniciPremiumTipVM()
            {
                ID = a.ID,
                TipAdı = a.TipAdi,
                HedefPuan = Convert.ToInt32(a.HedefPuan)                
            }).ToList();
        }
    }
}
