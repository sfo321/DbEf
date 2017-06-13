namespace EFCodeFirstProject.MainMigrations
{
    using System;
    using EFCodeFirstProject.Models;
    using System.Data.Entity.Migrations;


    internal sealed class MainConfig : DbMigrationsConfiguration<MainDbContext>
    {
        public MainConfig()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MainMigrations";
        }

        protected override void Seed(MainDbContext context)
        {
            var supplier = new Supplier()
            {
                Name = "Milk Factory LTD",
                Category = IngredientCategories.MilkProducts
            };

            context.Suppliers.Add(supplier);

            var order = new Order()
            {
                DeliveryDate = DateTime.Now.AddDays(3),
                Supplier = supplier
            };

            context.Orders.Add(order);

            var ingredient = new Ingredient()
            {
                Name = "Yellow Cheese",
                Price = 16.8M,
                Category = IngredientCategories.MilkProducts,
                ActualQuantity = 100,
                PendingQuantity = 1000
            };

            context.Ingredients.Add(ingredient);

            var recipeIngredient = new RecipeIngredient()
            {
                Name = "Yellow Cheese",
                Quantity = 50,
                Ingredient = ingredient
            };

            context.RecipeIngredients.Add(recipeIngredient);

            var recipe = new Recipe()
            {
                Name = "Margarita"
            };

            context.Recipes.Add(recipe);

            var pizza = new Pizza()
            {
                Name = "Margarita",
                Price = 5.50M,
                Weight = 600,
                Quantity = 1,
                Recipe = recipe
            };

            context.Pizzas.Add(pizza);
            context.SaveChanges();
        }
    }
}
