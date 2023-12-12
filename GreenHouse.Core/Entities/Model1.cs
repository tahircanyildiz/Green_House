using GreenHouse.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;


namespace Model
{
    public partial class Model1 : DbContext
    {

        public Model1() : base("server=.;Database=GreenHouseDB2;Trusted_Connection=True")
        {
        }

        public virtual DbSet<Aktivite> Aktivite { get; set; }
        public virtual DbSet<AramaGecmisi> AramaGecmisi { get; set; }
        public virtual DbSet<Bilesen> Bilesen { get; set; }
        public virtual DbSet<Eleman> Eleman { get; set; }
        public virtual DbSet<Firma> Firma { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciAktivite> KullaniciAktivite { get; set; }
        public virtual DbSet<KullaniciListesi> KullaniciListesi { get; set; }
        public virtual DbSet<KullaniciRolu> KullaniciRolu { get; set; }
        public virtual DbSet<KullaniciTipi> KullaniciTipi { get; set; }
        public virtual DbSet<KullaniciUygulamaIzni> KullaniciUygulamaIzni { get; set; }
        public virtual DbSet<ListeIcerigi> ListeIcerigi { get; set; }
        public virtual DbSet<ListeTip> ListeTip { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Resim> Resim { get; set; }
        public virtual DbSet<Risk> Risk { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Sayfa> Sayfa { get; set; }
        public virtual DbSet<SayfaYetki> SayfaYetki { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<UrunFirma> UrunFirma { get; set; }
        public virtual DbSet<UrunIcerik> UrunIcerik { get; set; }
        public virtual DbSet<UrunKategori> UrunKategori { get; set; }
        public virtual DbSet<UrunOnay> UrunOnay { get; set; }
        public virtual DbSet<UygulamaAyar> UygulamaAyar { get; set; }
        public virtual DbSet<UygulamaIzinTip> UygulamaIzinTip { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }
        public virtual DbSet<MenuEleman> MenuEleman { get; set; }
        public virtual DbSet<SayfaMenu> SayfaMenu { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aktivite>()
                .HasMany(e => e.KullaniciAktivite)
                .WithRequired(e => e.Aktivite)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bilesen>()
                .HasMany(e => e.UrunIcerik)
                .WithRequired(e => e.Bilesen)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Eleman>()
            //    .HasMany(e => e.Menu)
            //    .WithMany(e => e.Eleman)
            //    .Map(m => m.ToTable("MenuEleman").MapLeftKey("ElemanID").MapRightKey("MenuID"));

            modelBuilder.Entity<Firma>()
                .HasMany(e => e.UrunFirma)
                .WithRequired(e => e.Firma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KullaniciListesi>()
                .HasMany(e => e.KullaniciListesi1)
                .WithOptional(e => e.KullaniciListesi2)
                .HasForeignKey(e => e.ÜstListeID);

            modelBuilder.Entity<KullaniciListesi>()
                .HasMany(e => e.ListeIcerigi)
                .WithRequired(e => e.KullaniciListesi)
                .HasForeignKey(e => e.ListeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KullaniciRolu>()
                .HasMany(e => e.KullaniciAktivite)
                .WithRequired(e => e.KullaniciRolu)
                .HasForeignKey(e => e.KullaniciRolID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KullaniciRolu>()
                .HasMany(e => e.KullaniciListesi)
                .WithOptional(e => e.KullaniciRolu)
                .HasForeignKey(e => e.KullaniciRolID);

            modelBuilder.Entity<KullaniciRolu>()
                .HasMany(e => e.KullaniciUygulamaIzni)
                .WithOptional(e => e.KullaniciRolu)
                .HasForeignKey(e => e.KullaniciRolID);

            modelBuilder.Entity<KullaniciRolu>()
                .HasMany(e => e.UrunOnay)
                .WithOptional(e => e.KullaniciRolu)
                .HasForeignKey(e => e.EkleyenKullaniciRolID);

            modelBuilder.Entity<KullaniciRolu>()
                .HasMany(e => e.UrunOnay1)
                .WithOptional(e => e.KullaniciRolu1)
                .HasForeignKey(e => e.InceleyenKullaniciRolID);

            modelBuilder.Entity<ListeTip>()
                .HasMany(e => e.KullaniciListesi)
                .WithOptional(e => e.ListeTip)
                .HasForeignKey(e => e.ListeTipiID);

            //modelBuilder.Entity<Menu>()
            //    .HasMany(e => e.Sayfa)
            //    .WithMany(e => e.Menu)
            //    .Map(m => m.ToTable("SayfaMenu").MapLeftKey("MenuID").MapRightKey("SayfaID"));

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.UrunFirma)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.UrunIcerik)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UrunKategori>()
                .HasMany(e => e.Urun)
                .WithOptional(e => e.UrunKategori)
                .HasForeignKey(e => e.KategoriID);

            modelBuilder.Entity<UrunKategori>()
                .HasMany(e => e.UrunKategori1)
                .WithOptional(e => e.UrunKategori2)
                .HasForeignKey(e => e.UstKategoriID);
        }
    }
}
