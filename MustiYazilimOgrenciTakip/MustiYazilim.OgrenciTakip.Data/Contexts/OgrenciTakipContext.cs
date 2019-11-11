using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MustiYazilim.OgrenciTakip.Data.OgrenciTakipMigration;
using MustiYazilim.OgrenciTakip.Model.Entities;

namespace MustiYazilim.OgrenciTakip.Data.Contexts
{
    public class OgrenciTakipContext : BaseDbContext<OgrenciTakipContext,Configuration>
    {
        public OgrenciTakipContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public OgrenciTakipContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Okul> Okul { get; set; }
    }
}