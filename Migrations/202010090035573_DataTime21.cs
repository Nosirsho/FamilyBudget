namespace FamilyBudget.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataTime21 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Consums", "ConsDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Consums", "ConsDate", c => c.DateTime(nullable: false));
        }
    }
}
