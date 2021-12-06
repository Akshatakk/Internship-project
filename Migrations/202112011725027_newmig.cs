namespace AutomobileServiceStation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PaymentInfoes", "total", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PaymentInfoes", "total");
        }
    }
}
