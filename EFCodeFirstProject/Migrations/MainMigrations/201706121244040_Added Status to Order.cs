namespace EFCodeFirstProject.MainMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStatustoOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ingredients", "ActualQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Ingredients", "PendingQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Ingredients", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingredients", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Status");
            DropColumn("dbo.Ingredients", "PendingQuantity");
            DropColumn("dbo.Ingredients", "ActualQuantity");
        }
    }
}
