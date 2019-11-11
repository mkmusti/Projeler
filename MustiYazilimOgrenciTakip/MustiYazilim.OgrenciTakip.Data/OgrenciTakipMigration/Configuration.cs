using MustiYazilim.OgrenciTakip.Data.Contexts;
using System.Data.Entity.Migrations;

namespace MustiYazilim.OgrenciTakip.Data.OgrenciTakipMigration
{
    public class Configuration : DbMigrationsConfiguration<OgrenciTakipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}