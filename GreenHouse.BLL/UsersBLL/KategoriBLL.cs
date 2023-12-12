using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.BLL.UsersBLL
{
    public class KategoriBLL
    {
        KategoriDAL kategoriDAL;
        public KategoriBLL()
        {
            kategoriDAL = new KategoriDAL();
        }

        public List<KategoriVM> GetirKategoriBLL()
        {
            return kategoriDAL.Getir();
        }

        public KategoriVM IcerigeGöreKategoriGetirBLL(UrunVM urunVM)
        {
            return kategoriDAL.IcerigeGöreKategoriGetir(urunVM);
        }
    }
}
