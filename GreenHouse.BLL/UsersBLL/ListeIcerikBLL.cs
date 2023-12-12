using EfDeneme.DAL.Concrete;
using GreenHouse.Core.Common;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.User;
using GreenHouse.VM.VM;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class ListeIcerikBLL
    {
        ListeIcerikDAL icerikDAL;
        public ListeIcerikBLL()
        {
            icerikDAL = new ListeIcerikDAL(); 
        }
        GeneralReturnType<GirisYapKullaniciVM> gelenUser = UserSingleton.Instance.GelenUser;
        public List<ListeIcerikVM> ListeIcerikGetir(Guid kullaniciRolID, int listeTipi)
        {
            return icerikDAL.ListeIcerikGetir(kullaniciRolID, listeTipi);
        }
        public GeneralReturnType<ListeIcerikVM> KaraListeIcerikEkle(ListeIcerikVM listeIcerikVM)
        {
            if (ListedeIcerikVarMi(listeIcerikVM))
            {
                return new GeneralReturnType<ListeIcerikVM>() { Datas = null, Message = "Daha önce bir favori listesinine veya kara listeye  eklenmiş", StatusCode = 400 };
            }
           
            GeneralReturnType<ListeIcerikVM> returns = new GeneralReturnType<ListeIcerikVM>();
            try
            {
                EFRepo<ListeIcerigi> ef = new EFRepo<ListeIcerigi>();
                var donenListeIcerik = ef.Add(new ListeIcerigi() { ID = listeIcerikVM.ID, ListeID = listeIcerikVM.ListeID, UrunMu = listeIcerikVM.UrunMu, IcerikID = listeIcerikVM.IcerikID, });

                if (returns == null)
                {
                    returns.Datas = null;
                    returns.Message = "Ekleme Başarısız.";
                    returns.StatusCode = 400;
                }
                else
                {
                    returns.Datas = new ListeIcerikVM() { ID = donenListeIcerik.ID, ListeID = donenListeIcerik.ListeID, UrunMu = (bool)donenListeIcerik.UrunMu, IcerikID = donenListeIcerik.IcerikID };
                    returns.Message = "Ekleme Başarılı";
                    returns.StatusCode = 200;
                }
            }
            catch (Exception)
            {

                throw;
            }
            

            return returns;
        }
        public GeneralReturnType<ListeIcerikVM> FavoriListesineIcerikEkle(ListeIcerikVM listeIcerikVM)
        {
            GeneralReturnType<ListeIcerikVM> returns = new GeneralReturnType<ListeIcerikVM>();
            //listede var mı kontrol et.
            if (ListedeIcerikVarMi(listeIcerikVM))
            {
                return new GeneralReturnType<ListeIcerikVM>() { Datas = null, Message = "Daha önce bir favori listesinine veya kara listeye  eklenmiş", StatusCode = 400 };
            }
            try
            {
                EFRepo<ListeIcerigi> eFRepo = new EFRepo<ListeIcerigi>();
                var gelenVeri = eFRepo.Add(new ListeIcerigi() { ID = listeIcerikVM.ID, ListeID = listeIcerikVM.ListeID, UrunMu = listeIcerikVM.UrunMu, IcerikID = listeIcerikVM.IcerikID });
                

                if (gelenVeri != null)
                {
                    returns.Datas = new ListeIcerikVM() { ID = gelenVeri.ID, ListeID = gelenVeri.ListeID, UrunMu = (bool)gelenVeri.UrunMu, IcerikID = gelenVeri.IcerikID };
                    returns.Message = "Ekleme işlemi başarılı";
                    returns.StatusCode = 200;
                }
                else
                {
                    returns.Datas = null;
                    returns.Message = "Ekleme Başarısız";
                    returns.StatusCode = 400;
                }
            }
            catch (Exception)
            {

                throw;
            }

            
            return returns;
        }

        public GeneralReturnType<ListeIcerikVM> ListeIcerikSil(ListeIcerikVM listeIcerikVM)
        {
            GeneralReturnType<ListeIcerikVM> returns = new GeneralReturnType<ListeIcerikVM>();
            try
            {
                EFRepo<ListeIcerigi> eFRepo = new EFRepo<ListeIcerigi>();
                var gelen = eFRepo.SoftDelete(new ListeIcerigi() { ID = listeIcerikVM.ID, ListeID = listeIcerikVM.ListeID, IcerikID = listeIcerikVM.IcerikID, UrunMu = listeIcerikVM.UrunMu });

                if (gelen != null)
                {
                    returns.Datas = new ListeIcerikVM() { ID = gelen.ID };
                    returns.Message = "başarılı";
                    returns.StatusCode = 200;
                }
                else
                {
                    returns.Datas = null;
                    returns.Message = "veri silinemedi";
                    returns.StatusCode = 400;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return returns;
        }
        public bool ListedeIcerikVarMi(ListeIcerikVM listeIcerikVM)
        {
            //senaryo1
            EFRepo<ListeIcerigi> eFRepo = new EFRepo<ListeIcerigi>();
            var gelen = eFRepo.SelectOneById(a=>a.IcerikID==listeIcerikVM.IcerikID && a.ListeID==listeIcerikVM.ListeID) ;
            if (gelen==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public GeneralReturnType<List<ListeIcerikVM>> FavoriListeGoreVeriGetir(Guid listeID)
        {
            ListeIcerikDAL listeIcerikDAL = new ListeIcerikDAL();
            var gelenListe= listeIcerikDAL.FavoriListeGoreVeriGetir(listeID);
            GeneralReturnType<List<ListeIcerikVM>> returns = new GeneralReturnType<List<ListeIcerikVM>>();
            if (gelenListe!= null)
            {
                returns.Datas = gelenListe;
                returns.Message = "veri geldi";
                returns.StatusCode = 200;
            }
            else
            {
                returns.Datas = null;
                returns.Message = "veri yok";
                returns.StatusCode = 400;
            }
            return returns;
        }
        public GeneralReturnType<List<ListeIcerikVM>> KaraListeBilesenGetir(Guid kullaniciRolID,int listeTipi)
        {
            GeneralReturnType<List<ListeIcerikVM>> returns = new GeneralReturnType<List<ListeIcerikVM>>();
            var gelen = icerikDAL.ListeTipineGoreBilesenGetir(kullaniciRolID, listeTipi);
            if (gelen!=null)
            {
                returns.Datas = gelen.Datas;
                returns.Message = gelen.Message;
                returns.StatusCode = gelen.StatusCode;
            }
            else
            {
                returns.Datas = gelen.Datas;
                returns.Message = gelen.Message;
                returns.StatusCode = gelen.StatusCode;
            }
            return returns;
        }





    }
}
