using LocCapacita.DTO.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.DAL.Models.Mapping
{
    public class TagsComptMap : EntityTypeConfiguration<TagsCompt>
    {
        public TagsComptMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTagsCompt);

            // Properties
            this.Property(t => t.NomeCompt)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("TagsCompt");
            this.Property(t => t.IdTagsCompt).HasColumnName("IdTagsCompt");
            this.Property(t => t.NomeCompt).HasColumnName("NomeCompt");
            this.Property(t => t.DtCad).HasColumnName("DtCad");
        }
    }
}
