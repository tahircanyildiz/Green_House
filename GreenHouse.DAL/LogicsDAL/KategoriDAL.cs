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
    public class KategoriDAL
    {
        public List<KategoriVM> Getir()
        {
            EFRepo<UrunKategori> DAL = new EFRepo<UrunKategori>(new Model1());
            return DAL.SelectAll().Select(a => new KategoriVM()
            {
                ID = a.ID,
                KategoriAdi = a.KategoriAdi
            }).ToList();
        }

        public KategoriVM IcerigeGöreKategoriGetir(UrunVM urunVM)
        {
            EFRepo<UrunKategori> DAL = new EFRepo<UrunKategori>(new Model1());
            var kategori = DAL.SelectByID(urunVM.KategoriID);
            MyMapper<UrunKategori, KategoriVM> mapper = new MyMapper<UrunKategori, KategoriVM>();
            var result = mapper.Map(kategori);
            return result;
        }
    }
}
