using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Teste.Models.Mapping
{
    public class AvalcMap : EntityTypeConfiguration<Avalc>
    {
        public AvalcMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAvalc);

            // Properties
            this.Property(t => t.Coment)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("Avalc");
            this.Property(t => t.IdAvalc).HasColumnName("IdAvalc");
            this.Property(t => t.IdPrflAvalc).HasColumnName("IdPrflAvalc");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.Coment).HasColumnName("Coment");
            this.Property(t => t.DtAvalc).HasColumnName("DtAvalc");
            this.Property(t => t.Ativo).HasColumnName("Ativo");
            this.Property(t => t.IdAgndCapct).HasColumnName("IdAgndCapct");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");

            // Relationships
            this.HasOptional(t => t.AgndCapct)
                .WithMany(t => t.Avalcs)
                .HasForeignKey(d => d.IdAgndCapct);
            this.HasRequired(t => t.Prfl)
                .WithMany(t => t.Avalcs)
                .HasForeignKey(d => d.IdPrflAvalc);
            this.HasOptional(t => t.Prfl1)
                .WithMany(t => t.Avalcs1)
                .HasForeignKey(d => d.IdPrfl);

        }
    }
}
