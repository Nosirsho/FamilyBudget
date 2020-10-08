namespace FamilyBudget.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ConsCategories", "Name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Consums", "Descr", c => c.String(maxLength: 255));
            AlterColumn("dbo.IncCategories", "Name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Incomes", "Descr", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Incomes", "Descr", c => c.String());
            AlterColumn("dbo.IncCategories", "Name", c => c.String());
            AlterColumn("dbo.Consums", "Descr", c => c.String());
            AlterColumn("dbo.ConsCategories", "Name", c => c.String());
        }
    }
}
