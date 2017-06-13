using EFCodeFirstProject.Models;
using System.Data.Entity;

namespace EFCodeFirstProject
{
    public class PgDbContext : DbContext, IContext
    {
        public PgDbContext() : base("PostgresDotNet")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}