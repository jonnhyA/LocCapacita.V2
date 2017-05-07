using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Teste.Models.Mapping
{
    public class PrflMap : EntityTypeConfiguration<Prfl>
    {
        public PrflMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPrfl);

            // Properties
            this.Property(t => t.ImgPrfl)
                .HasMaxLength(100);

            this.Property(t => t.DescrPrfl)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("Prfl");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");
            this.Property(t => t.ImgPrfl).HasColumnName("ImgPrfl");
            this.Property(t => t.DtCadPrfl).HasColumnName("DtCadPrfl");
            this.Property(t => t.TpoPrfl).HasColumnName("TpoPrfl");
            this.Property(t => t.DescrPrfl).HasColumnName("DescrPrfl");
        }
    }
}
