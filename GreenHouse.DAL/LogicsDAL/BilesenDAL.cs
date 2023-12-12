using EfDeneme.DAL.Concrete;
using EfDeneme.DAL.Mapper;
using GreenHouse.Core.Common;
using GreenHouse.VM.User;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class BilesenDAL
    {
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        public List<BilesenVM> TumBilesenGetir()
        {
            return new EFRepo<Bilesen>().SelectAll().Select(a => new BilesenVM()
            {
                ID = a.ID,
                Adi = a.Adi,
                Aciklama = a.Aciklama,
                RiskID = (int)a.RiskID
            }).ToList();
        }
        public List<BilesenVM> UrunBilesikGetir(UrunBilesenVM urun)
        {
            return new EFRepo<Bilesen>().SelectAll(a => a.ID == urun.BilesenID).Select(a => new BilesenVM()
            {
                ID = a.ID,
                Adi = a.Adi,
                Aciklama = a.Aciklama,
                RiskID = (int)a.RiskID
            }).ToList();
        }

        public BilesenVM BilesenEkle(BilesenVM bilesenVM)
        {
            EFRepo<Bilesen> bilesen = null;
            try
            {
                bilesen = new EFRepo<Bilesen>(new Model1());
                MyMapper<BilesenVM, Bilesen> mapper = new MyMapper<BilesenVM, Bilesen>();
                Bilesen bilesen1 = mapper.Map(bilesenVM);
                bilesen.Add(bilesen1);
                return bilesenVM;
            }
            catch
            {
                bilesen = null;
                return null;
            }
        }

        public BilesenVM IDIleGetir(Guid ID)
        {
            try
            {
                var data = new EFRepo<Bilesen>().SelectById(ID);
                MyMapper<Bilesen, BilesenVM> mapper = new MyMapper<Bilesen, BilesenVM>();
                BilesenVM bilesenVM = mapper.Map(data);
                return bilesenVM;
            }
            catch
            {
                return null;
            }
            //return new EFRepo<Bilesen>().SelectAll(a => a.ID == ID).Select(a => new BilesenVM()
            //{
            //    ID = a.ID,
            //    Adi = a.Adi,
            //    Aciklama = a.Aciklama,
            //    RiskID = (int)a.RiskID
            //}).ToList();
        }
        public bool UrunBilesenEkleTransaction(List<Tuple<string, int, string>> values, UrunVM urun)
        {
            Random r = new Random();
            Model1 db = new Model1();
            using (DbContextTransaction dbContextTransaction = db.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                try
                {

                    foreach (var item in values)
                    {
                        var bilesen = BilesenVarsaOlaniGetir(item.Item1);
                        if (bilesen == null)
                        {
                            var data = BilesenEkle(new BilesenVM()
                            {
                                ID = Guid.NewGuid(),
                                Adi = item.Item1.ToString(),
                                Aciklama = item.Item3.ToString(),
                                RiskID = item.Item2,
                                AktifMi = true,
                                OlusturulmaTarihi = DateTime.Now,
                                OlusturanKullaniciRolID = gelenUser.Datas.KullaniciRoluID
                            });
                            bool firmaEklendiMi = new UrunBilesenDAL().UrunIcerikEkle(new UrunBilesenVM()
                            {
                                BilesenID = data.ID,
                                UrunID = urun.ID
                            });
                        }
                        else
                        {
                            var data = bilesen;
                            bool firmaEklendiMi = new UrunBilesenDAL().UrunIcerikEkle(new UrunBilesenVM()
                            {
                                BilesenID = data.ID,
                                UrunID = urun.ID
                            });
                        }

                    }


                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {

                    dbContextTransaction.Rollback();

                    return false;
                }
            }

        }

        public BilesenVM BilesenVarsaOlaniGetir(string bilesenIsmı)
        {
            Model1 context = new Model1();
            var secilenBilesen = (from b in context.Bilesen
                                  where b.Adi == bilesenIsmı
                                  select b).FirstOrDefault();
            MyMapper<Bilesen, BilesenVM> mapper = new MyMapper<Bilesen, BilesenVM>();
            var secilenBilesenVM = mapper.Map(secilenBilesen);
            return secilenBilesenVM;
        }
    }
}
