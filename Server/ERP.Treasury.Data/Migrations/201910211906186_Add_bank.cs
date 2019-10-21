namespace ERP.Treasury_back.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_bank : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Accounting.BANK",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Accounting.BANK");
        }
    }
}
