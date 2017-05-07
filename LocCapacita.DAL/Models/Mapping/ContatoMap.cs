using LocCapacita.DTO.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.DAL.Models.Mapping
{
    public class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdCtto);

            // Properties
            this.Property(t => t.DescrCtto)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Contato");
            this.Property(t => t.IdCtto).HasColumnName("IdCtto");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");
            this.Property(t => t.IdTpoCtto).HasColumnName("IdTpoCtto");
            this.Property(t => t.DescrCtto).HasColumnName("DescrCtto");

            // Relationships
            this.HasOptional(t => t.Prfl)
                .WithMany(t => t.Contatoes)
                .HasForeignKey(d => d.IdPrfl);

        }
    }
}
