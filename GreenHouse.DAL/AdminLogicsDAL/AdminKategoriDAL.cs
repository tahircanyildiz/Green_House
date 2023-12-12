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
    public class AdminKategoriDAL
    {
        private MyEntityMapper mapper = new MyEntityMapper();
        public List<AdminKategoriVM> Get()
        {
            return mapper.Map<List<AdminKategoriVM>, List<UrunKategori>>(new EFRepo<UrunKategori>().SelectAll());
        }
        //public List<AdminKategoriVM> UstKategorileriGetir()
        //{
        //    Model1 db = new Model1();
        //    List<UrunKategori> ustKategoriler = (from kat in db.UrunKategori
        //                                         where kat.ID == kat.UstKategoriID
        //                                         select kat).ToList();
        //    return new MyEntityMapper().Map<List<AdminKategoriVM>, List<UrunKategori>>(ustKategoriler);
        //}

        public List<AdminKategoriVM> GetKategorilerWithName(string name)
        {
            Model1 db = new Model1();
            List<UrunKategori> liste = (from k in db.UrunKategori
                                 where k.KategoriAdi.Contains(name)
                                 select k).ToList();
            return new MyEntityMapper().Map<List<AdminKategoriVM>, List<UrunKategori>>(liste);
        }

        public AdminKategoriVM Add(AdminKategoriVM urunKategoriVM)
        {
            if (new EFRepo<UrunKategori>().MukerrerMi(x => x.KategoriAdi == urunKategoriVM.KategoriAdi))
            {
                throw new Exception("Kategori Mevcut");
            }
            return mapper.Map<AdminKategoriVM, UrunKategori>(new EFRepo<UrunKategori>().Add(mapper.Map<UrunKategori, AdminKategoriVM>(urunKategoriVM)));
        }
        public AdminKategoriVM AddUstKategori(AdminKategoriVM urunKategoriVM)
        {
            EFRepo<UrunKategori> efRepo = new EFRepo<UrunKategori>();

            UrunKategori urunKategori = efRepo.Add(mapper.Map<UrunKategori, AdminKategoriVM>(urunKategoriVM));
            urunKategori.UstKategoriID = urunKategori.ID;

            return mapper.Map<AdminKategoriVM, UrunKategori>(efRepo.Update(urunKategori));
        }
        public AdminKategoriVM HardDelete(AdminKategoriVM urunKategoriVM)
        {
            return mapper.Map<AdminKategoriVM, UrunKategori>(new EFRepo<UrunKategori>().HardDelete(mapper.Map<UrunKategori, AdminKategoriVM>(urunKategoriVM)));
        }
        public AdminKategoriVM SoftDelete(AdminKategoriVM urunKategoriVM)
        {
            return mapper.Map<AdminKategoriVM, UrunKategori>(new EFRepo<UrunKategori>().SoftDelete(mapper.Map<UrunKategori, AdminKategoriVM>(urunKategoriVM)));
        }
        public AdminKategoriVM Update(AdminKategoriVM urunKategoriVM)
        {
            return mapper.Map<AdminKategoriVM, UrunKategori>(new EFRepo<UrunKategori>().Update(mapper.Map<UrunKategori, AdminKategoriVM>(urunKategoriVM)));
        }
        public AdminKategoriVM GetUstKategoriByID(int id)
        {
            return mapper.Map<AdminKategoriVM, UrunKategori>(new EFRepo<UrunKategori>().SelectOneById(a => a.UstKategoriID == id));
        }
        public List<AdminKategoriVM> GetAltKategoriLerByUstKategori(int id)
        {
            return mapper.Map<List<AdminKategoriVM>, List<UrunKategori>>(new EFRepo<UrunKategori>().SelectAll(a => a.UstKategoriID == id));
        }
        public List<AdminKategoriVM> AltKategorileriGetir()
        {
            Model1 db = new Model1();
            List<UrunKategori> ustKategoriler = (from kat in db.UrunKategori
                                                 where kat.ID != kat.UstKategoriID
                                                 select kat).ToList();
            return new MyEntityMapper().Map<List<AdminKategoriVM>, List<UrunKategori>>(ustKategoriler);
        }
        public AdminKategoriVM GetKategoriByID(int ID)
        {
            return new MyEntityMapper().Map<AdminKategoriVM, UrunKategori>(new EFRepo<UrunKategori>().SelectOneById(a => a.ID == ID));
        }
    }
}
