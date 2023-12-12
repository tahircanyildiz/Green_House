namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciRolu")]
    public partial class KullaniciRolu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KullaniciRolu()
        {
            KullaniciAktivite = new HashSet<KullaniciAktivite>();
            KullaniciListesi = new HashSet<KullaniciListesi>();
            KullaniciUygulamaIzni = new HashSet<KullaniciUygulamaIzni>();
            UrunOnay = new HashSet<UrunOnay>();
            UrunOnay1 = new HashSet<UrunOnay>();
        }

        public Guid ID { get; set; }

        public Guid? KullaniciID { get; set; }

        public int? RolID { get; set; }

        public DateTime? RoleAtandigiZaman { get; set; }

        public bool? AktifMi { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciAktivite> KullaniciAktivite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciListesi> KullaniciListesi { get; set; }

        public virtual Rol Rol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciUygulamaIzni> KullaniciUygulamaIzni { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunOnay> UrunOnay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunOnay> UrunOnay1 { get; set; }
    }
}
