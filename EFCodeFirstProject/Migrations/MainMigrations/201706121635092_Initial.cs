namespace EFCodeFirstProject.MainMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActualQuantity = c.Int(nullable: false),
                        PendingQuantity = c.Int(nullable: false),
                        Category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "Index");
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeliveryDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Supplier_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_Id, cascadeDelete: true)
                .Index(t => t.Supplier_Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "Index");
            
            CreateTable(
                "dbo.RecipeIngredients",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ingredients", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "Index");
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Recipe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id, cascadeDelete: true)
                .Index(t => t.Name, unique: true, name: "Index")
                .Index(t => t.Recipe_Id);
            
            CreateTable(
                "dbo.IngredientOrders",
                c => new
                    {
                        Ingredient_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ingredient_Id, t.Order_Id })
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .Index(t => t.Ingredient_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.RecipeRecipeIngredients",
                c => new
                    {
                        Recipe_Id = c.Int(nullable: false),
                        RecipeIngredient_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Recipe_Id, t.RecipeIngredient_Id })
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id, cascadeDelete: true)
                .ForeignKey("dbo.RecipeIngredients", t => t.RecipeIngredient_Id, cascadeDelete: true)
                .Index(t => t.Recipe_Id)
                .Index(t => t.RecipeIngredient_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecipeIngredients", "Id", "dbo.Ingredients");
            DropForeignKey("dbo.RecipeRecipeIngredients", "RecipeIngredient_Id", "dbo.RecipeIngredients");
            DropForeignKey("dbo.RecipeRecipeIngredients", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Pizzas", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.IngredientOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.IngredientOrders", "Ingredient_Id", "dbo.Ingredients");
            DropForeignKey("dbo.Orders", "Supplier_Id", "dbo.Suppliers");
            DropIndex("dbo.RecipeRecipeIngredients", new[] { "RecipeIngredient_Id" });
            DropIndex("dbo.RecipeRecipeIngredients", new[] { "Recipe_Id" });
            DropIndex("dbo.IngredientOrders", new[] { "Order_Id" });
            DropIndex("dbo.IngredientOrders", new[] { "Ingredient_Id" });
            DropIndex("dbo.Pizzas", new[] { "Recipe_Id" });
            DropIndex("dbo.Pizzas", "Index");
            DropIndex("dbo.Recipes", "Index");
            DropIndex("dbo.RecipeIngredients", new[] { "Id" });
            DropIndex("dbo.Suppliers", "Index");
            DropIndex("dbo.Orders", new[] { "Supplier_Id" });
            DropIndex("dbo.Ingredients", "Index");
            DropTable("dbo.RecipeRecipeIngredients");
            DropTable("dbo.IngredientOrders");
            DropTable("dbo.Pizzas");
            DropTable("dbo.Recipes");
            DropTable("dbo.RecipeIngredients");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Orders");
            DropTable("dbo.Ingredients");
        }
    }
}
