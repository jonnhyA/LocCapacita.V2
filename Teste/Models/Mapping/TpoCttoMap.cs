using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Teste.Models.Mapping
{
    public class TpoCttoMap : EntityTypeConfiguration<TpoCtto>
    {
        public TpoCttoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTpoCtto);

            // Properties
            this.Property(t => t.NomeCtto)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("TpoCtto");
            this.Property(t => t.IdTpoCtto).HasColumnName("IdTpoCtto");
            this.Property(t => t.NomeCtto).HasColumnName("NomeCtto");
            this.Property(t => t.DtCad).HasColumnName("DtCad");
            this.Property(t => t.DtFimCad).HasColumnName("DtFimCad");
        }
    }
}
