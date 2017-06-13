namespace EFCodeFirstProject.MainMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCategorytoIngredients : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ingredients", "Category", c => c.Int(nullable: false));
            AlterColumn("dbo.Suppliers", "Category", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "Category", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Ingredients", "Category");
        }
    }
}
