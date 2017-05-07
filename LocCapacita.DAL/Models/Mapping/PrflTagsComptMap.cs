using LocCapacita.DTO.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.DAL.Models.Mapping
{
    public class PrflTagsComptMap : EntityTypeConfiguration<PrflTagsCompt>
    {
        public PrflTagsComptMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IdPrfl, t.IdTagsCompt, t.DtCad });

            // Properties
            this.Property(t => t.IdPrfl)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IdTagsCompt)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PrflTagsCompt");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");
            this.Property(t => t.IdTagsCompt).HasColumnName("IdTagsCompt");
            this.Property(t => t.DtCad).HasColumnName("DtCad");

            // Relationships
            this.HasRequired(t => t.Prfl)
                .WithMany(t => t.PrflTagsCompts)
                .HasForeignKey(d => d.IdPrfl);
            this.HasRequired(t => t.TagsCompt)
                .WithMany(t => t.PrflTagsCompts)
                .HasForeignKey(d => d.IdTagsCompt);

        }
    }
}
