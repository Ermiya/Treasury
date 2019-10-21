namespace ERP.Treasury_back.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Accounting.TAXTABLE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TAX_YEAR = c.Short(nullable: false),
                        FROM_INCOME = c.Int(nullable: false),
                        TO_INCOME = c.Int(nullable: false),
                        TAX_PERCENT = c.Single(nullable: false),
                        CreatorUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        LastModifierUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Accounting.TAXTABLE");
        }
    }
}
