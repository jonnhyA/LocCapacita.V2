using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Teste.Models.Mapping
{
    public class PrflInscritoMap : EntityTypeConfiguration<PrflInscrito>
    {
        public PrflInscritoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPrflInscrito);

            // Properties
            // Table & Column Mappings
            this.ToTable("PrflInscrito");
            this.Property(t => t.IdPrflInscrito).HasColumnName("IdPrflInscrito");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");
            this.Property(t => t.AgndCapct).HasColumnName("AgndCapct");
            this.Property(t => t.Pago).HasColumnName("Pago");
            this.Property(t => t.DtPago).HasColumnName("DtPago");

            // Relationships
            this.HasRequired(t => t.AgndCapct1)
                .WithMany(t => t.PrflInscritoes)
                .HasForeignKey(d => d.AgndCapct);
            this.HasRequired(t => t.Prfl)
                .WithMany(t => t.PrflInscritoes)
                .HasForeignKey(d => d.IdPrfl);

        }
    }
}
