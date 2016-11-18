using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Eticaret.Models.Mapping
{
    public class SepetMap : EntityTypeConfiguration<Sepet>
    {
        public SepetMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Sepet");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.KullaniciId).HasColumnName("KullaniciId");
            this.Property(t => t.UrunId).HasColumnName("UrunId");
        }
    }
}
