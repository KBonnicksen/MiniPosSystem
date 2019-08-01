namespace MiniPosSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentInfoes",
                c => new
                    {
                        CardId = c.Int(nullable: false, identity: true),
                        CardNumber = c.Int(nullable: false),
                        NameOnCard = c.String(),
                        CardType = c.String(),
                    })
                .PrimaryKey(t => t.CardId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Transactions_TransactionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Transactions", t => t.Transactions_TransactionId)
                .Index(t => t.Transactions_TransactionId);
            
            CreateTable(
                "dbo.Servers",
                c => new
                    {
                        ServerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ServerId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        ServerId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Transactions_TransactionId", "dbo.Transactions");
            DropIndex("dbo.Products", new[] { "Transactions_TransactionId" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Servers");
            DropTable("dbo.Products");
            DropTable("dbo.PaymentInfoes");
        }
    }
}
