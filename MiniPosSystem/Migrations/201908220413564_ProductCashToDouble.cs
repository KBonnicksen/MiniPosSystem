namespace MiniPosSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductCashToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PaymentInfoes", "CashTendered", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PaymentInfoes", "CashTendered", c => c.Double());
        }
    }
}
