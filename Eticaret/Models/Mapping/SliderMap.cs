using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Eticaret.Models.Mapping
{
    public class SliderMap : EntityTypeConfiguration<Slider>
    {
        public SliderMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Slider");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.ResimYolu).HasColumnName("ResimYolu");
            this.Property(t => t.BirResimYolu).HasColumnName("BirResimYolu");
            this.Property(t => t.İkiResimYolu).HasColumnName("İkiResimYolu");
        }
    }
}
