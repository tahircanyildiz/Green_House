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
    public class UrunFirmaDAL
    {
        public List<FirmaVM> FirmaGetir()
        {
            return new EFRepo<Firma>().SelectAll().Select(a => new FirmaVM()
            {
                ID = a.ID,
                FirmaAdi = a.FirmaAdi,
                FirmaAdresi = a.FirmaAdresi,
                FirmaTel = a.FirmaTel
            }).ToList();
        }

        public bool EkleUrunFirma(UrunFirmaVM urunFirmaVM)
        {
            EFRepo<UrunFirma> urunFirma = null;
            try
            {
                urunFirma = new EFRepo<UrunFirma>(new Model1());
                MyMapper<UrunFirmaVM, UrunFirma> mapper = new MyMapper<UrunFirmaVM, UrunFirma>();
                UrunFirma urun1 = mapper.Map(urunFirmaVM);
                urunFirma.Add(urun1);
                return true;
            }
            catch
            {
                urunFirma = null;
                return false;
            }
        }
        
    }
}
