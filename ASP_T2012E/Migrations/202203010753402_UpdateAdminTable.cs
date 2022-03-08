namespace ASP_T2012E.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAdminTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "Username", c => c.String(nullable: false));
            DropColumn("dbo.Admins", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Admins", "Username", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
