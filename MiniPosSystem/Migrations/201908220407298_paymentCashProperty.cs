namespace MiniPosSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paymentCashProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PaymentInfoes", "CashTendered", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PaymentInfoes", "CashTendered");
        }
    }
}
