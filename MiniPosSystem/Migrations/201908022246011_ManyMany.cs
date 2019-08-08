namespace MiniPosSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManyMany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Transactions_TransactionId", "dbo.Transactions");
            DropIndex("dbo.Products", new[] { "Transactions_TransactionId" });
            CreateTable(
                "dbo.TransactionsProducts",
                c => new
                    {
                        Transactions_TransactionId = c.Int(nullable: false),
                        Products_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Transactions_TransactionId, t.Products_Id })
                .ForeignKey("dbo.Transactions", t => t.Transactions_TransactionId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Products_Id, cascadeDelete: true)
                .Index(t => t.Transactions_TransactionId)
                .Index(t => t.Products_Id);
            
            AddColumn("dbo.Transactions", "PaymentInfo_CardId", c => c.Int());
            AddColumn("dbo.Transactions", "Server_ServerId", c => c.Int());
            CreateIndex("dbo.Transactions", "PaymentInfo_CardId");
            CreateIndex("dbo.Transactions", "Server_ServerId");
            AddForeignKey("dbo.Transactions", "PaymentInfo_CardId", "dbo.PaymentInfoes", "CardId");
            AddForeignKey("dbo.Transactions", "Server_ServerId", "dbo.Servers", "ServerId");
            DropColumn("dbo.Products", "Transactions_TransactionId");
            DropColumn("dbo.Transactions", "ServerId");
            DropColumn("dbo.Transactions", "CardId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "CardId", c => c.Int());
            AddColumn("dbo.Transactions", "ServerId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Transactions_TransactionId", c => c.Int());
            DropForeignKey("dbo.Transactions", "Server_ServerId", "dbo.Servers");
            DropForeignKey("dbo.TransactionsProducts", "Products_Id", "dbo.Products");
            DropForeignKey("dbo.TransactionsProducts", "Transactions_TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "PaymentInfo_CardId", "dbo.PaymentInfoes");
            DropIndex("dbo.TransactionsProducts", new[] { "Products_Id" });
            DropIndex("dbo.TransactionsProducts", new[] { "Transactions_TransactionId" });
            DropIndex("dbo.Transactions", new[] { "Server_ServerId" });
            DropIndex("dbo.Transactions", new[] { "PaymentInfo_CardId" });
            DropColumn("dbo.Transactions", "Server_ServerId");
            DropColumn("dbo.Transactions", "PaymentInfo_CardId");
            DropTable("dbo.TransactionsProducts");
            CreateIndex("dbo.Products", "Transactions_TransactionId");
            AddForeignKey("dbo.Products", "Transactions_TransactionId", "dbo.Transactions", "TransactionId");
        }
    }
}
