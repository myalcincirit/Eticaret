using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Eticaret.Models.Mapping
{
    public class UrunlerMap : EntityTypeConfiguration<Urunler>
    {
        public UrunlerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.UrunAdi)
                .HasMaxLength(50);

            this.Property(t => t.UrunFiyati)
                .HasMaxLength(50);

            this.Property(t => t.UrunRengi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Urunler");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.UrunFiyati).HasColumnName("UrunFiyati");
            this.Property(t => t.UrunAciklamasi).HasColumnName("UrunAciklamasi");
            this.Property(t => t.UrunResimYol).HasColumnName("UrunResimYol");
            this.Property(t => t.UrunRengi).HasColumnName("UrunRengi");
            this.Property(t => t.cResimId).HasColumnName("cResimId");
            this.Property(t => t.kUrunResim).HasColumnName("kUrunResim");
            this.Property(t => t.Tarih).HasColumnName("Tarih");
            this.Property(t => t.kkUrunResim).HasColumnName("kkUrunResim");
            this.Property(t => t.KategoriId).HasColumnName("KategoriId");
        }
    }
}
