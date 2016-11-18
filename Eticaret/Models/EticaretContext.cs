using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Eticaret.Models.Mapping;

namespace Eticaret.Models
{
    public partial class EticaretContext : DbContext
    {
        static EticaretContext()
        {
            Database.SetInitializer<EticaretContext>(null);
        }

        public EticaretContext()
            : base("Name=EticaretContext")
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Kullanicilar> Kullanicilars { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new KategorilerMap());
            modelBuilder.Configurations.Add(new KullanicilarMap());
            modelBuilder.Configurations.Add(new SliderMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UrunlerMap());
        }
    }
}
