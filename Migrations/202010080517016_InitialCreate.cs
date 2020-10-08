namespace FamilyBudget.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConsCategories",
                c => new
                    {
                        ConsCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ConsCategoryId);
            
            CreateTable(
                "dbo.Consums",
                c => new
                    {
                        ConsumId = c.Int(nullable: false, identity: true),
                        ConsDate = c.DateTime(nullable: false),
                        ConsSum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descr = c.String(),
                        ConsCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ConsumId)
                .ForeignKey("dbo.ConsCategories", t => t.ConsCategoryId)
                .Index(t => t.ConsCategoryId);
            
            CreateTable(
                "dbo.IncCategories",
                c => new
                    {
                        IncCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IncCategoryId);
            
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        IncomeId = c.Int(nullable: false, identity: true),
                        IncDate = c.DateTime(nullable: false),
                        IncSum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descr = c.String(),
                        IncCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.IncomeId)
                .ForeignKey("dbo.IncCategories", t => t.IncCategoryId)
                .Index(t => t.IncCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Incomes", "IncCategoryId", "dbo.IncCategories");
            DropForeignKey("dbo.Consums", "ConsCategoryId", "dbo.ConsCategories");
            DropIndex("dbo.Incomes", new[] { "IncCategoryId" });
            DropIndex("dbo.Consums", new[] { "ConsCategoryId" });
            DropTable("dbo.Incomes");
            DropTable("dbo.IncCategories");
            DropTable("dbo.Consums");
            DropTable("dbo.ConsCategories");
        }
    }
}
