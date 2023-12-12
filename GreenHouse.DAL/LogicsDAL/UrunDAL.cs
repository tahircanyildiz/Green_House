using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.DAL.Concrete;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class UrunDAL
    {
        public List<UrunVM> Getir()
        {
            EFRepo<Urun> DAL = new EFRepo<Urun>();
            return DAL.SelectAll(a=> a.AktifMi == true).Select(a => new UrunVM()
            {
                ID = a.ID,
                UrunAdi = a.UrunAdi,
                KategoriID = (int)a.KategoriID
            }).ToList();
        }
        //urunun diğer bilgilerini de çek// ürün content vs
        public List<UrunVM> KategoriIleGetir(KategoriVM kategori)
        {

            return new EFRepo<Urun>().SelectAll(a => a.KategoriID == kategori.ID && a.AktifMi == true).Select(a => new UrunVM()
            {
                ID = a.ID,
                UrunAdi = a.UrunAdi,
                KategoriID = (int)a.KategoriID
            }).ToList();
        }
        //bi milyon data basınca patlar mıyız hmmm?//over contains
        //searching algorithm // look fro elastic search
        public List<UrunVM> AdIleGetir(string name)
        {
            List<UrunVM> urunVMs = new List<UrunVM>();
            Model1 context = new Model1();
            var data = (from s in context.Urun
                        where s.UrunAdi.ToLower().Contains(name.ToLower())
                        && s.AktifMi == true
                        select s).ToList();            
            MyMapper<Urun, UrunVM> mapper = new MyMapper<Urun, UrunVM>();
            data.ForEach(a => urunVMs.Add(mapper.Map(a)));
            return urunVMs;
        }

        public UrunVM EkleUrun(UrunVM urunVM)
        {
            EFRepo<Urun> urun = null;
            try
            {
                urun = new EFRepo<Urun>(new Model1());
                MyMapper<UrunVM, Urun> mapper = new MyMapper<UrunVM, Urun>();
                Urun urun1 = mapper.Map(urunVM);
                urun.Add(urun1);
                return urunVM;
            }
            catch(Exception ex)
            {
                urun = null;
                return null;
            }
        }

        public UrunVM BarkodaGoreUrunGetir(string barkod)
        {
            try
            {
                Model1 context = new Model1();
                var secilenUrun = (from s in context.Urun
                                   where s.BarkodNumarasi == barkod
                                   select s).FirstOrDefault();
                MyMapper<Urun, UrunVM> mapper = new MyMapper<Urun, UrunVM>();
                UrunVM urunVM = mapper.Map(secilenUrun);
                return urunVM;
            }
            catch
            {
                return null;
            }
            
        }

        public UrunVM IDIleGetir(Guid ID)
        {
            try
            {
                var data = new EFRepo<Urun>().SelectByID(ID);
                MyMapper<Urun, UrunVM> mapper = new MyMapper<Urun, UrunVM>();
                UrunVM urunVM = mapper.Map(data);
                return urunVM;
            }
            catch
            {
                return null;
            }
            
        }
        public bool UrunFirmaEkleTransaction(UrunVM urunVM,params UrunFirmaVM[] urunFirmaVM)
        {
            bool control = false;
            MyMapper<UrunVM, Urun> mapper = new MyMapper<UrunVM, Urun>();
            MyMapper<UrunFirmaVM, UrunFirma> mapper1 = new MyMapper<UrunFirmaVM, UrunFirma>();
            List<UrunFirma> list = new List<UrunFirma>();
            foreach (var item in urunFirmaVM.ToList())
            {
                list.Add(mapper1.Map(item));
            }
            try
            {
                new EFRepoTransaction<Urun, UrunFirma>().AddOneToN(mapper.Map(urunVM), list.ToArray());
                control = true;
            }
            catch (Exception ex)
            {
                control = false;
            }
            return control;
        }
        public bool UrunBilesenEkleTransaction(UrunVM urunVM, params UrunBilesenVM[] urunBilesenVM)
        {
            bool control = false;
            MyMapper<UrunVM, Urun> mapper = new MyMapper<UrunVM, Urun>();
            MyMapper<UrunBilesenVM, UrunIcerik> mapper1 = new MyMapper<UrunBilesenVM, UrunIcerik>();
            List<UrunIcerik> list = new List<UrunIcerik>();

            foreach (var item in urunBilesenVM.ToList())
            {
                list.Add(mapper1.Map(item));
            }
            try
            {
                new EFRepoTransaction<Urun, UrunIcerik>().AddOneToN(mapper.Map(urunVM), list.ToArray());
                control = true;
            }
            catch (Exception ex)
            {
                control = false;
            }
            return control;
        }
        public bool UrunFirmaEkleTransaction(UrunVM urunVM, List<FirmaVM> Firma, UrunOnayInsertVM urunOnayInsertVM, List<string> resimYollari)
        {
            UrunVM eklenenUrun = null;
            Model1 db = new Model1();
            using (DbContextTransaction dbContextTransaction = db.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                try
                {
                    eklenenUrun = EkleUrun(urunVM);
                    foreach (var item in Firma)
                    {
                        bool firmaEklendiMi = new UrunFirmaDAL().EkleUrunFirma(new UrunFirmaVM()
                        {
                            UrunID = eklenenUrun.ID,
                            FirmaID = item.ID
                        });
                    }
                    new UrunOnayDAL().EkleUrunOnay(new UrunOnayInsertVM()
                    {
                        ID = urunOnayInsertVM.ID,
                        UrunID = eklenenUrun.ID,
                        EkleyenKullaniciRolID = urunOnayInsertVM.EkleyenKullaniciRolID,
                        InceleyenKullaniciRolID = urunOnayInsertVM.InceleyenKullaniciRolID,
                        TakipNumarasi = urunOnayInsertVM.TakipNumarasi,
                        OnayDurumu = urunOnayInsertVM.OnayDurumu,
                        KullaniciGozukmeDurumu = urunOnayInsertVM.KullaniciGozukmeDurumu
                    });
                    foreach (var item in resimYollari)
                    {
                        new ResimDAL().ResimEkle(new ResimInsertVM()
                        {
                            ID = Guid.NewGuid(),
                            UrunID = eklenenUrun.ID,
                            ResimYuzu = true,
                            ResimYolu = item,
                            AktifMi = true,
                            OlusturanKullaniciRolID = (Guid)eklenenUrun.OlusturanKullaniciRolID,
                            OlusturmaTarihi = DateTime.Now
                        });
                    }
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {

                    dbContextTransaction.Rollback();
                    eklenenUrun = null;
                    return false;
                }
            }

        }

        public bool UrunVarMi(string urunIsmi)
        {
            try
            {
                Model1 context = new Model1();
                var secilenUrun = (from s in context.Urun
                                   where s.UrunAdi == urunIsmi
                                   select s).FirstOrDefault();
                if (secilenUrun != null)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
//urun ekleme->urun firma->         //Bilesen->UrunBilesen->