using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Eticaret.Models.Mapping
{
    public class KullanicilarMap : EntityTypeConfiguration<Kullanicilar>
    {
        public KullanicilarMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Ad)
                .HasMaxLength(50);

            this.Property(t => t.Soyad)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            this.Property(t => t.Tel)
                .HasMaxLength(50);

            this.Property(t => t.Adress)
                .HasMaxLength(100);

            this.Property(t => t.Sehir)
                .HasMaxLength(50);

            this.Property(t => t.Sifre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Kullanicilar");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Ad).HasColumnName("Ad");
            this.Property(t => t.Soyad).HasColumnName("Soyad");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Adress).HasColumnName("Adress");
            this.Property(t => t.Sehir).HasColumnName("Sehir");
            this.Property(t => t.Sifre).HasColumnName("Sifre");
        }
    }
}
