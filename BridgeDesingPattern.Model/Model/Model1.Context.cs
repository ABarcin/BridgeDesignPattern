//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BridgeDesingPattern.Model.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Slytherin_AracIhaleEntities : DbContext
    {
        public Slytherin_AracIhaleEntities()
            : base("name=Slytherin_AracIhaleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public DbSet<ArabaModel> ArabaModel { get; set; }
        public DbSet<Arac> Arac { get; set; }
        public DbSet<AracFiyat> AracFiyat { get; set; }
        public DbSet<AracOzellik> AracOzellik { get; set; }
        public DbSet<AracParca> AracParca { get; set; }
        public DbSet<AracStatu> AracStatu { get; set; }
        public DbSet<AracTeklif> AracTeklif { get; set; }
        public DbSet<AracTramer> AracTramer { get; set; }
        public DbSet<AracTramerDetay> AracTramerDetay { get; set; }
        public DbSet<Calisan> Calisan { get; set; }
        public DbSet<CalisanIletisim> CalisanIletisim { get; set; }
        public DbSet<Ekspertiz> Ekspertiz { get; set; }
        public DbSet<FavoriArama> FavoriArama { get; set; }
        public DbSet<FavoriAramaKriter> FavoriAramaKriter { get; set; }
        public DbSet<FavoriIlan> FavoriIlan { get; set; }
        public DbSet<FavoriOzellik> FavoriOzellik { get; set; }
        public DbSet<Firma> Firma { get; set; }
        public DbSet<FirmaIletisim> FirmaIletisim { get; set; }
        public DbSet<FirmaTip> FirmaTip { get; set; }
        public DbSet<Fotograf> Fotograf { get; set; }
        public DbSet<Ihale> Ihale { get; set; }
        public DbSet<IhaleArac> IhaleArac { get; set; }
        public DbSet<IhaleStatu> IhaleStatu { get; set; }
        public DbSet<IhaleSurec> IhaleSurec { get; set; }
        public DbSet<Ilan> Ilan { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<IletisimTur> IletisimTur { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<KullaniciIletisim> KullaniciIletisim { get; set; }
        public DbSet<KullaniciTip> KullaniciTip { get; set; }
        public DbSet<KurumsalIhale> KurumsalIhale { get; set; }
        public DbSet<KurumsalKullanici> KurumsalKullanici { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<LogError> LogError { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<Ozellik> Ozellik { get; set; }
        public DbSet<OzellikBilgi> OzellikBilgi { get; set; }
        public DbSet<Paket> Paket { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolYetki> RolYetki { get; set; }
        public DbSet<Sayfa> Sayfa { get; set; }
        public DbSet<Sehir> Sehir { get; set; }
        public DbSet<SehirIlce> SehirIlce { get; set; }
        public DbSet<Statu> Statu { get; set; }
        public DbSet<Stok> Stok { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TramerDetay> TramerDetay { get; set; }
        public DbSet<Yetki> Yetki { get; set; }
    }
}
