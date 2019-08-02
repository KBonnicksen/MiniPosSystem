namespace MiniPosSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlloNulls : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "CardId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "CardId", c => c.Int(nullable: false));
        }
    }
}
