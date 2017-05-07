using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using LocCapacita.DAL.Models.Mapping;
using LocCapacita.DTO.Entities;

namespace LocCapacita.DAL
{
    public partial class LocCapacitaContext : DbContext
    {
        static LocCapacitaContext()
        {
            Database.SetInitializer<LocCapacitaContext>(null);
        }

        public LocCapacitaContext()
            : base("Name=LocCapacitaContext")
        {
        }

        public DbSet<AcssoSite> AcssoSites { get; set; }
        public DbSet<AgndCapct> AgndCapcts { get; set; }
        public DbSet<Assunto> Assuntoes { get; set; }
        public DbSet<AssuntoAvalc> AssuntoAvalcs { get; set; }
        public DbSet<Avalc> Avalcs { get; set; }
        public DbSet<AvalcPrfl> AvalcPrfls { get; set; }
        public DbSet<Busca> Buscas { get; set; }
        public DbSet<Capct> Capcts { get; set; }
        public DbSet<Contato> Contatoes { get; set; }
        public DbSet<DetlheCapct> DetlheCapcts { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Prfl> Prfls { get; set; }
        public DbSet<PrflInscrito> PrflInscritoes { get; set; }
        public DbSet<PrflInstrutorPrfl> PrflInstrutorPrfls { get; set; }
        public DbSet<PrflTagsCompt> PrflTagsCompts { get; set; }
        public DbSet<Representante> Representantes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TagsCompt> TagsCompts { get; set; }
        public DbSet<TpoCtto> TpoCttoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AcssoSiteMap());
            modelBuilder.Configurations.Add(new AgndCapctMap());
            modelBuilder.Configurations.Add(new AssuntoMap());
            modelBuilder.Configurations.Add(new AssuntoAvalcMap());
            modelBuilder.Configurations.Add(new AvalcMap());
            modelBuilder.Configurations.Add(new AvalcPrflMap());
            modelBuilder.Configurations.Add(new BuscaMap());
            modelBuilder.Configurations.Add(new CapctMap());
            modelBuilder.Configurations.Add(new ContatoMap());
            modelBuilder.Configurations.Add(new DetlheCapctMap());
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new PrflMap());
            modelBuilder.Configurations.Add(new PrflInscritoMap());
            modelBuilder.Configurations.Add(new PrflInstrutorPrflMap());
            modelBuilder.Configurations.Add(new PrflTagsComptMap());
            modelBuilder.Configurations.Add(new RepresentanteMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TagsComptMap());
            modelBuilder.Configurations.Add(new TpoCttoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
