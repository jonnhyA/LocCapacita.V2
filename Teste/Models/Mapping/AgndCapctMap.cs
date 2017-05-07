using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Teste.Models.Mapping
{
    public class AgndCapctMap : EntityTypeConfiguration<AgndCapct>
    {
        public AgndCapctMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAgndCapct);

            // Properties
            // Table & Column Mappings
            this.ToTable("AgndCapct");
            this.Property(t => t.IdAgndCapct).HasColumnName("IdAgndCapct");
            this.Property(t => t.IdDetlheCapct).HasColumnName("IdDetlheCapct");
            this.Property(t => t.TpoCapct).HasColumnName("TpoCapct");
            this.Property(t => t.IdPrflInstrutor).HasColumnName("IdPrflInstrutor");
            this.Property(t => t.IdLocal).HasColumnName("IdLocal");
            this.Property(t => t.DtInit).HasColumnName("DtInit");
            this.Property(t => t.DtFim).HasColumnName("DtFim");
            this.Property(t => t.HrInit).HasColumnName("HrInit");
            this.Property(t => t.HrFim).HasColumnName("HrFim");
            this.Property(t => t.Cetficado).HasColumnName("Cetficado");
            this.Property(t => t.PrepCerticacao).HasColumnName("PrepCerticacao");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");
            this.Property(t => t.CargaHr).HasColumnName("CargaHr");

            // Relationships
            this.HasRequired(t => t.DetlheCapct)
                .WithMany(t => t.AgndCapcts)
                .HasForeignKey(d => d.IdDetlheCapct);
            this.HasRequired(t => t.Prfl)
                .WithMany(t => t.AgndCapcts)
                .HasForeignKey(d => d.IdPrfl);
            this.HasRequired(t => t.Prfl1)
                .WithMany(t => t.AgndCapcts1)
                .HasForeignKey(d => d.IdPrflInstrutor);

        }
    }
}
