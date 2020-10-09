namespace FamilyBudget.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataTime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Incomes", "IncDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Incomes", "IncDate", c => c.DateTime(nullable: false));
        }
    }
}
