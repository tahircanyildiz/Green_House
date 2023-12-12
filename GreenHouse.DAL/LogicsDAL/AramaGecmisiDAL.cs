using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class AramaGecmisiDAL
    {
        public List<AramaGecmisiVM> GetirAramaGecmisi(Guid kullaniciID)
        {
            EFRepo<AramaGecmisi> DAL = new EFRepo<AramaGecmisi>(new Model1());
            return DAL.SelectAll(a => a.KullaniciID == kullaniciID)
                .Where(a => a.KullaniciID != null && a.AramaZamani != null && a.AktifMi != null)
                .Select(a => new AramaGecmisiVM()
                {
                    ID = a.ID,
                    AramaMetni = a.AramaMetni,
                    KullaniciID = (Guid)a.KullaniciID,
                    AramaZamani = (DateTime)a.AramaZamani,
                    AktifMi = (bool)a.AktifMi
                }).ToList();
        }
        public bool EkleAramaGecmisi(AramaGecmisiVM aramaGecmisiVM)
        {
            EFRepo<AramaGecmisi> gecmis = null;
            try
            {
                gecmis = new EFRepo<AramaGecmisi>(new Model1());
                MyMapper<AramaGecmisiVM, AramaGecmisi> mapper = new MyMapper<AramaGecmisiVM, AramaGecmisi>();
                AramaGecmisi aramaGecmisi = mapper.Map(aramaGecmisiVM);
                gecmis.Add(aramaGecmisi);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SilAramaGecmisi(AramaGecmisiVM aramaGecmisiVM)
        {
            EFRepo<AramaGecmisi> gecmis = null;
            try
            {
                gecmis = new EFRepo<AramaGecmisi>(new Model1());
                MyMapper<AramaGecmisiVM, AramaGecmisi> mapper = new MyMapper<AramaGecmisiVM, AramaGecmisi>();
                AramaGecmisi aramaGecmisi = mapper.Map(aramaGecmisiVM);
                gecmis.HardDelete(aramaGecmisi);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SilTümAramaGecmisi(List<AramaGecmisiVM> aramaGecmisiVMs)
        {
            EFRepo<AramaGecmisi> gecmis = null;
            try
            {
                
                gecmis = new EFRepo<AramaGecmisi>(new Model1());
                MyMapper<AramaGecmisiVM, AramaGecmisi> mapper = new MyMapper<AramaGecmisiVM, AramaGecmisi>();
                foreach(var a in aramaGecmisiVMs)
                {
                    var b = mapper.Map(a);                   
                    gecmis.HardDelete(b);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
