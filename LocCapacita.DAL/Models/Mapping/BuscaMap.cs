using LocCapacita.DTO.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.DAL.Models.Mapping
{
    public class BuscaMap : EntityTypeConfiguration<Busca>
    {
        public BuscaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdBusca);

            // Properties
            this.Property(t => t.IdBusca)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Busca");
            this.Property(t => t.IdBusca).HasColumnName("IdBusca");
        }
    }
}
