using LocCapacita.DTO.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.DAL.Models.Mapping
{
    public class PrflInstrutorPrflMap : EntityTypeConfiguration<PrflInstrutorPrfl>
    {
        public PrflInstrutorPrflMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IdPrfl, t.IdPrflInstrutor, t.DtCad, t.DtFim });

            // Properties
            this.Property(t => t.IdPrfl)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IdPrflInstrutor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PrflInstrutorPrfl");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");
            this.Property(t => t.IdPrflInstrutor).HasColumnName("IdPrflInstrutor");
            this.Property(t => t.DtCad).HasColumnName("DtCad");
            this.Property(t => t.DtFim).HasColumnName("DtFim");

            // Relationships
            this.HasRequired(t => t.Prfl)
                .WithMany(t => t.PrflInstrutorPrfls)
                .HasForeignKey(d => d.IdPrfl);
            this.HasRequired(t => t.Prfl1)
                .WithMany(t => t.PrflInstrutorPrfls1)
                .HasForeignKey(d => d.IdPrflInstrutor);
            this.HasRequired(t => t.Prfl2)
                .WithMany(t => t.PrflInstrutorPrfls2)
                .HasForeignKey(d => d.IdPrflInstrutor);

        }
    }
}
