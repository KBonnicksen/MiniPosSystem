namespace MiniPosSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CardIDToUlong : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PaymentInfoes", "CardNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PaymentInfoes", "CardNumber", c => c.Int(nullable: false));
        }
    }
}
