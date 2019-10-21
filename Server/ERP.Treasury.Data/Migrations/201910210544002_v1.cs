namespace ERP.Treasury_back.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Document_types",
                c => new
                    {
                        SRL = c.Double(nullable: false),
                        DES = c.String(),
                        PRIORITY = c.Double(),
                        SYSTEM_SRL = c.Double(),
                        ENDDOC = c.Double(),
                        DOCUMENT_TYPES_SRL = c.String(),
                        VISIBLE = c.Double(),
                        DETAILED_ACCOUNT_TITLE = c.String(),
                        DETAILED_ACCOUNT_SIDE_TITLE = c.String(),
                        BACK_DOC = c.Double(),
                        DETAILED_GROUP_LIST = c.String(),
                        DETAILED_GROUP_SIDE_LIST = c.String(),
                        BANKDOC_NO_FLAG = c.Double(),
                        REFRENCE_FLAG = c.Double(),
                        DETAILED_ACCOUNT_LIST = c.String(),
                        DETAILED_ACCOUNT_SIDE_LIST = c.String(),
                        LOAN_FLAG = c.String(),
                        REFRENCE_DES = c.String(),
                        BANK_DATE_FLAG = c.String(),
                        CHECK_NO_FLAG = c.String(),
                        NATURE = c.String(),
                        BANK_NO_TITLE = c.String(),
                        BANK_DATE_TITLE = c.String(),
                    })
                .PrimaryKey(t => t.SRL);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Document_types");
        }
    }
}
