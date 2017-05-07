using LocCapacita.DTO.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.DAL.Models.Mapping
{
    public class DetlheCapctMap : EntityTypeConfiguration<DetlheCapct>
    {
        public DetlheCapctMap()
        {
            // Primary Key
            this.HasKey(t => t.IdDetlheCapct);

            // Properties
            this.Property(t => t.DescrCapct)
                .IsRequired()
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("DetlheCapct");
            this.Property(t => t.IdDetlheCapct).HasColumnName("IdDetlheCapct");
            this.Property(t => t.IdCapct).HasColumnName("IdCapct");
            this.Property(t => t.IdPrflv).HasColumnName("IdPrflv");
            this.Property(t => t.DescrCapct).HasColumnName("DescrCapct");

            // Relationships
            this.HasRequired(t => t.Capct)
                .WithMany(t => t.DetlheCapcts)
                .HasForeignKey(d => d.IdCapct);
            this.HasRequired(t => t.Prfl)
                .WithMany(t => t.DetlheCapcts)
                .HasForeignKey(d => d.IdPrflv);

        }
    }
}
