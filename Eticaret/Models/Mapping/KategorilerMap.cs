using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Eticaret.Models.Mapping
{
    public class KategorilerMap : EntityTypeConfiguration<Kategoriler>
    {
        public KategorilerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.KategoriAd)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Kategoriler");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.KategoriAd).HasColumnName("KategoriAd");
            this.Property(t => t.Urunİd).HasColumnName("Urunİd");
        }
    }
}
