using LocCapacita.DTO.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.DAL.Models.Mapping
{
    public class CapctMap : EntityTypeConfiguration<Capct>
    {
        public CapctMap()
        {
            // Primary Key
            this.HasKey(t => t.IdCapct);

            // Properties
            this.Property(t => t.NomeCapct)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Capct");
            this.Property(t => t.IdCapct).HasColumnName("IdCapct");
            this.Property(t => t.NomeCapct).HasColumnName("NomeCapct");
            this.Property(t => t.IdPrflCad).HasColumnName("IdPrflCad");
            this.Property(t => t.DtCad).HasColumnName("DtCad");

            // Relationships
            this.HasRequired(t => t.Prfl)
                .WithMany(t => t.Capcts)
                .HasForeignKey(d => d.IdPrflCad);

        }
    }
}
