using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Teste.Models.Mapping
{
    public class AssuntoAvalcMap : EntityTypeConfiguration<AssuntoAvalc>
    {
        public AssuntoAvalcMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAsstn);

            // Properties
            this.Property(t => t.IdAsstn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssuntoAvalc");
            this.Property(t => t.IdAvalcAssnt).HasColumnName("IdAvalcAssnt");
            this.Property(t => t.IdAsstn).HasColumnName("IdAsstn");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");

            // Relationships
            this.HasRequired(t => t.Assunto)
                .WithOptional(t => t.AssuntoAvalc);
            this.HasOptional(t => t.Avalc)
                .WithMany(t => t.AssuntoAvalcs)
                .HasForeignKey(d => d.IdAvalcAssnt);

        }
    }
}
