namespace N.FourWar.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users_RenameColumn_Password : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PasswordHash", c => c.String(maxLength: 4000));
            DropColumn("dbo.Users", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Password", c => c.String(maxLength: 4000));
            DropColumn("dbo.Users", "PasswordHash");
        }
    }
}
