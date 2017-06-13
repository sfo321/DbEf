using EFCodeFirstProject.Configurations;
using EFCodeFirstProject.Models;
using System.Data.Entity;

namespace EFCodeFirstProject
{
    public class MainDbContext : DbContext, IContext
    {
        public MainDbContext() : base("StoreConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RecipeConfiguration());
            modelBuilder.Configurations.Add(new PizzaConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new IngredientConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new RecipeIngredientConfiguration());
        }

        public IDbSet<Order> Orders { get; set; }

        public IDbSet<Supplier> Suppliers { get; set; }

        public IDbSet<Pizza> Pizzas { get; set; }

        public IDbSet<Recipe> Recipes { get; set; }

        public IDbSet<Ingredient> Ingredients { get; set; }

        public IDbSet<RecipeIngredient> RecipeIngredients { get; set; }
    }
}