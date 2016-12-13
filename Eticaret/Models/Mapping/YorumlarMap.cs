using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Eticaret.Models.Mapping
{
    public class YorumlarMap : EntityTypeConfiguration<Yorumlar>
    {
        public YorumlarMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Ad)
                .HasMaxLength(50);

            this.Property(t => t.SoyAd)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Yorum)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Yorumlar");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Ad).HasColumnName("Ad");
            this.Property(t => t.SoyAd).HasColumnName("SoyAd");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Yorum).HasColumnName("Yorum");
            this.Property(t => t.UrunId).HasColumnName("UrunId");
        }
    }
}
