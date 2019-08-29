namespace MiniPosSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class getAddOnItems : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Products_Id", c => c.Int());
            CreateIndex("dbo.Products", "Products_Id");
            AddForeignKey("dbo.Products", "Products_Id", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Products_Id", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Products_Id" });
            DropColumn("dbo.Products", "Products_Id");
        }
    }
}
