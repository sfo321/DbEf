using EFCodeFirstProject.LiteMigrations;
using EFCodeFirstProject.Models;
using System.Data.Entity;

namespace EFCodeFirstProject
{
    public class LiteDbContext : DbContext, IContext
    {
        public LiteDbContext() : base("SqliteDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LiteDbContext, LiteConfig>(true));
        }
    }
}