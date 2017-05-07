using LocCapacita.DTO.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.DAL.Models.Mapping
{
    public class AssuntoMap : EntityTypeConfiguration<Assunto>
    {
        public AssuntoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAsstn);

            // Properties
            this.Property(t => t.NomeAssnt)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DescrAssnt)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Assunto");
            this.Property(t => t.IdAsstn).HasColumnName("IdAsstn");
            this.Property(t => t.NomeAssnt).HasColumnName("NomeAssnt");
            this.Property(t => t.DescrAssnt).HasColumnName("DescrAssnt");
            this.Property(t => t.DtCad).HasColumnName("DtCad");
        }
    }
}
