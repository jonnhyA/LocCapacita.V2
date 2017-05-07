using LocCapacita.DTO.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.DAL.Models.Mapping
{
    public class RepresentanteMap : EntityTypeConfiguration<Representante>
    {
        public RepresentanteMap()
        {
            // Primary Key
            this.HasKey(t => t.IdRpstt);

            // Properties
            // Table & Column Mappings
            this.ToTable("Representante");
            this.Property(t => t.IdRpstt).HasColumnName("IdRpstt");
            this.Property(t => t.IdPrflRpstt).HasColumnName("IdPrflRpstt");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");
            this.Property(t => t.DtCad).HasColumnName("DtCad");
            this.Property(t => t.DtCadFim).HasColumnName("DtCadFim");

            // Relationships
            this.HasRequired(t => t.Prfl)
                .WithMany(t => t.Representantes)
                .HasForeignKey(d => d.IdPrflRpstt);
            this.HasRequired(t => t.Prfl1)
                .WithMany(t => t.Representantes1)
                .HasForeignKey(d => d.IdPrfl);

        }
    }
}
