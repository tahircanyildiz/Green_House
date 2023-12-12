using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.VM.AdminVMs;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GreenHouse.DAL.AdminLogicsDAL
{
    public class AdminUrunDAL
    {
        public List<AdminUrunVM> Get()
        {
            return new MyEntityMapper().Map<List<AdminUrunVM>, List<Urun>>(new EFRepo<Urun>().SelectAll());
        }
        public List<AdminUrunVM> GetAktifler()
        {
            return new MyEntityMapper().Map<List<AdminUrunVM>, List<Urun>>(new EFRepo<Urun>().SelectAll(x=>x.AktifMi==true));
        }
        public AdminUrunVM Add(AdminUrunVM adminUrunVM)
        {
            MyEntityMapper map = new MyEntityMapper();
            return map.Map<AdminUrunVM, Urun>(new EFRepo<Urun>().Add(map.Map<Urun, AdminUrunVM>(adminUrunVM)));
        }
        public AdminUrunVM HardDelete(AdminUrunVM adminUrunVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminUrunVM, Urun>(new EFRepo<Urun>().HardDelete(mapper.Map<Urun, AdminUrunVM>(adminUrunVM)));
        }
        public AdminUrunVM SoftDelete(AdminUrunVM adminUrunVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminUrunVM, Urun>(new EFRepo<Urun>().SoftDelete(mapper.Map<Urun, AdminUrunVM>(adminUrunVM)));
        }
        public AdminUrunVM Update(AdminUrunVM adminUrunVM)
        {
            MyEntityMapper mapper = new MyEntityMapper();
            return mapper.Map<AdminUrunVM, Urun>(new EFRepo<Urun>().Update(mapper.Map<Urun, AdminUrunVM>(adminUrunVM)));
        }

        public AdminUrunVM UrunEkleTransaction(AdminUrunVM adminUrunVM,List<AdminFirmaVM> firmalar,List<AdminBilesenVM> bilesenler,List<AdminResimVM> resimler)
        {
            Model1 db = new Model1();
            MyEntityMapper mapper = new MyEntityMapper();
            using (DbContextTransaction transaction = db.Database.BeginTransaction())
            {
                try
                {
                    AdminUrunVM eklenenUrun = Add(adminUrunVM);
                    foreach (AdminFirmaVM firma in firmalar)
                    {
                        new EFRepo<UrunFirma>().Add(mapper.Map<UrunFirma, AdminUrunFirmaVM>(new AdminUrunFirmaVM() { UrunID = eklenenUrun.ID, FirmaID = firma.ID, AktifMi = true }));
                    }
                    foreach (AdminBilesenVM bilesen in bilesenler)
                    {
                        new EFRepo<UrunIcerik>().Add(mapper.Map<UrunIcerik, AdminUrunIcerikVM>(new AdminUrunIcerikVM() {UrunID=eklenenUrun.ID,BilesenID=bilesen.ID,AktifMİ=true }));
                    }
                    foreach (AdminResimVM resim in resimler)
                    {
                        new EFRepo<Resim>().Add(mapper.Map<Resim, AdminResimVM>(new AdminResimVM() {ID=resim.ID,AktifMi=resim.AktifMi,ResimYolu=resim.ResimYolu,ResimYuzu=resim.ResimYuzu,UrunID=eklenenUrun.ID}));
                    }
                    transaction.Commit();
                    return eklenenUrun;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return null;
                }
            }
        }
        public AdminUrunVM UrunGuncelleTransaction(AdminUrunVM adminUrunVM, List<AdminFirmaVM> firmalar, List<AdminBilesenVM> bilesenler, List<AdminResimVM> resimler)
        {

            Model1 db = new Model1();
            MyEntityMapper mapper = new MyEntityMapper();
            using (DbContextTransaction transaction = db.Database.BeginTransaction())
            {
                try
                {
                    AdminUrunVM guncellenenUrun = Update(adminUrunVM);

                    List<UrunFirma> firmalars = (from p in db.UrunFirma
                                                 where p.UrunID == guncellenenUrun.ID
                                                 select p).ToList();
                    firmalars.ForEach(x => db.UrunFirma.Remove(x));
                    foreach (AdminFirmaVM firma in firmalar)
                    {
                        db.UrunFirma.Add(mapper.Map<UrunFirma, AdminUrunFirmaVM>(new AdminUrunFirmaVM() { UrunID = guncellenenUrun.ID, AktifMi = true, FirmaID = firma.ID }));
                    }

                    List<UrunIcerik> bilesenlers = (from b in db.UrunIcerik
                                                    where b.UrunID == guncellenenUrun.ID
                                                    select b).ToList();
                    bilesenlers.ForEach(x =>db.UrunIcerik.Remove(x));
                    foreach (AdminBilesenVM bilesen in bilesenler)
                    {
                        db.UrunIcerik.Add(mapper.Map<UrunIcerik, AdminUrunIcerikVM>(new AdminUrunIcerikVM() { UrunID = guncellenenUrun.ID, BilesenID = bilesen.ID, AktifMİ = true }));
                    }
                    List<Resim> resimlers = (from r in db.Resim
                                            where r.UrunID == guncellenenUrun.ID
                                            select r).ToList();
                    resimlers.ForEach(x => db.Resim.Remove(x));
                    foreach (AdminResimVM resim in resimler)
                    {
                        db.Resim.Add(mapper.Map<Resim, AdminResimVM>(new AdminResimVM() { ID = resim.ID, AktifMi = resim.AktifMi, ResimYolu = resim.ResimYolu, ResimYuzu = resim.ResimYuzu, UrunID = guncellenenUrun.ID }));
                    }


                    transaction.Commit();
                    return guncellenenUrun;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return null;
                }
            }
        }
        public AdminUrunVM UrunSilTransaction(AdminUrunVM adminUrunVM, List<AdminFirmaVM> firmalar, List<AdminBilesenVM> bilesenler, List<AdminResimVM> resimler)
        {
            Model1 db = new Model1();
            MyEntityMapper mapper = new MyEntityMapper();
           
            using (DbContextTransaction transaction = db.Database.BeginTransaction())
            {
                try
                {

                    foreach (AdminResimVM resim in resimler)
                    {
                        Resim silinenr = mapper.Map<Resim, AdminResimVM>(new AdminResimVM() { ID = resim.ID, AktifMi = resim.AktifMi, ResimYolu = resim.ResimYolu, ResimYuzu = resim.ResimYuzu, UrunID = adminUrunVM.ID });
                        db.Resim.Attach(silinenr);
                        db.Entry(silinenr).State = EntityState.Deleted;
                        //db.Resim.Remove(db.Resim.Find (mapper.Map<Resim,AdminResimVM>(resim).ID));
                    }
                    //Urun silinenu = mapper.Map<Urun, AdminUrunVM>(adminUrunVM);
                    //AdminUrunVM returnData = mapper.Map<AdminUrunVM,Urun>(db.Urun.Attach(silinenu));
                    //db.Entry(silinenu).State = EntityState.Deleted;
                    AdminUrunVM silinenu =HardDelete(adminUrunVM);

                    foreach (AdminFirmaVM firma  in firmalar)
                    {
                        UrunFirma silinenuf = mapper.Map<UrunFirma, AdminUrunFirmaVM>(new AdminUrunFirmaVM() { AktifMi = true, UrunID = adminUrunVM.ID, FirmaID = firma.ID });
                        var data = db.UrunFirma.Attach(silinenuf);
                        db.Entry(silinenuf).State = EntityState.Deleted;
                       // db.UrunFirma.Remove(mapper.Map<UrunFirma,AdminUrunFirmaVM>(new AdminUrunFirmaVM() {AktifMi=true,UrunID=silinenUrun.ID,FirmaID=firma.ID })); 
                    }
                    foreach (AdminBilesenVM bilesen in bilesenler)
                    {
                        UrunIcerik silinenui = mapper.Map<UrunIcerik, AdminUrunIcerikVM>(new AdminUrunIcerikDAL().Delete(new AdminUrunIcerikVM() { AktifMİ = true, BilesenID = bilesen.ID, UrunID = adminUrunVM.ID }));
                        db.UrunIcerik.Attach(silinenui);
                        db.Entry(silinenui).State = EntityState.Deleted;
                       // db.UrunIcerik.Remove(silinenui);
                    }
                    
                    transaction.Commit();
                    return silinenu;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return null;
                }

            }

        }
    }
}

