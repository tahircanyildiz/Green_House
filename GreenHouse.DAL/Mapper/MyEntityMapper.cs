using AutoMapper;
using GreenHouse.Core.Entities;
using GreenHouse.VM.AdminVMs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDeneme.DAL.Mapper
{
    public class MyEntityMapper : Profile
    {
        MapperConfiguration MapperConfiguration;
        public MyEntityMapper()
        {
            this.CreateMap<AdminUrunVM, Urun>().ReverseMap();
            this.CreateMap<AdminFirmaVM, Firma>().ReverseMap();
            this.CreateMap<AdminKategoriVM, UrunKategori>().ReverseMap();
            this.CreateMap<AdminUrunFirmaVM, UrunFirma>().ReverseMap();
            this.CreateMap<AdminBilesenVM, Bilesen>().ReverseMap();
            this.CreateMap<AdminUrunIcerikVM, UrunIcerik>().ReverseMap();
            this.CreateMap<AdminResimVM, Resim>().ReverseMap();
            this.CreateMap<AdminYetkiVM, Yetki>().ReverseMap();
            this.CreateMap<AdminUygulamaVM, UygulamaAyar>().ReverseMap();
            this.CreateMap<AdminMenuVM, Menu>().ReverseMap();
            this.CreateMap<AdminElemanVM, Eleman>().ReverseMap();
            this.CreateMap<AdminMenuElemanVM, MenuEleman>().ReverseMap();
            this.CreateMap<AdminSayfaVM, Sayfa>().ReverseMap();
            this.CreateMap<AdminSayfaMenuVM, SayfaMenu>().ReverseMap();
            this.CreateMap<AdminRolVM, Rol>().ReverseMap();
            this.CreateMap<AdminRiskVM, Risk>().ReverseMap();
            this.CreateMap<AdminUrunOnayVM, UrunOnay>().ReverseMap();
            this.CreateMap<AdminKullaniciVM, Kullanici>().ReverseMap();


            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(this);
            });

        }
        

        public TCikis Map<TCikis, TGiris>(TGiris giris)
            where TGiris : class, new()
            where TCikis : class, new()
        {
            IMapper mapper = MapperConfiguration.CreateMapper();

            try
            {
                return mapper.Map<TCikis>(giris);
            }
            catch (Exception ex)
            {
                return null;
            }

        }


    }
}
