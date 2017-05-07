using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Teste.Models.Mapping
{
    public class AcssoSiteMap : EntityTypeConfiguration<AcssoSite>
    {
        public AcssoSiteMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAcssoSite);

            // Properties
            this.Property(t => t.IdAcssoSite)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AcssoSite");
            this.Property(t => t.IdAcssoSite).HasColumnName("IdAcssoSite");
        }
    }
}
