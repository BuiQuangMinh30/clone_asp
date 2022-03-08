namespace ASP_T2012E.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidateToAdminTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "PhoneVietNam", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "PhoneVietNam", c => c.String());
            AlterColumn("dbo.Admins", "Email", c => c.String());
            AlterColumn("dbo.Admins", "Password", c => c.String());
        }
    }
}
