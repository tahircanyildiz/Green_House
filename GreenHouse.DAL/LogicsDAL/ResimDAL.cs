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
    public class ResimDAL
    {
        public List<string> UruneGoreGetir(UrunVM urunVM)
        {
            List<string> myList = new List<string>();
            EFRepo<Resim> DAL = new EFRepo<Resim>();
            var data = DAL.SelectAll(a=> a.UrunID == urunVM.ID).Select(a => new ResimSelectVM()
            {
                ID = a.ID,
                UrunID = (Guid)a.UrunID,
                ResimYuzu = (bool)a.ResimYuzu,
                ResimYolu = a.ResimYolu
            }).ToList();
            data.ForEach(a => myList.Add(a.ResimYolu));
            return myList;
        }

        public ResimInsertVM ResimEkle(ResimInsertVM resimInsertVM)
        {
            EFRepo<Resim> resim = null;
            try
            {
                resim = new EFRepo<Resim>(new Model1());
                MyMapper<ResimInsertVM, Resim> mapper = new MyMapper<ResimInsertVM, Resim>();
                Resim resimInsert = mapper.Map(resimInsertVM);
                resim.Add(resimInsert);
                return resimInsertVM;
            }
            catch
            {
                resim = null;
                return null;
            }
        }
    }
}
