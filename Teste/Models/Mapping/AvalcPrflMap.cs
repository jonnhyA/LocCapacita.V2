using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Teste.Models.Mapping
{
    public class AvalcPrflMap : EntityTypeConfiguration<AvalcPrfl>
    {
        public AvalcPrflMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAvalcPrfl);

            // Properties
            this.Property(t => t.IdAvalcPrfl)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IdAsstn)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("AvalcPrfl");
            this.Property(t => t.IdAvalcPrfl).HasColumnName("IdAvalcPrfl");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");
            this.Property(t => t.IdAsstn).HasColumnName("IdAsstn");
        }
    }
}
