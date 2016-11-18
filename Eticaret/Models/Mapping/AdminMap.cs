using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Eticaret.Models.Mapping
{
    public class AdminMap : EntityTypeConfiguration<Admin>
    {
        public AdminMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.KullaniciAdi)
                .HasMaxLength(100);

            this.Property(t => t.Sifre)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Admin");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(t => t.Sifre).HasColumnName("Sifre");
        }
    }
}
