namespace ERP.Treasury_back.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_bank_1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Accounting.BANK", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("Accounting.BANK", "Name", c => c.String());
        }
    }
}
