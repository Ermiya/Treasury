namespace ERP.Treasury_back.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Document_types", newSchema: "Accounting");
        }
        
        public override void Down()
        {
            MoveTable(name: "Accounting.Document_types", newSchema: "dbo");
        }
    }
}
