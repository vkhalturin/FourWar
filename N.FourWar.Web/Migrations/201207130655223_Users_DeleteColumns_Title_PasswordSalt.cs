namespace N.FourWar.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users_DeleteColumns_Title_PasswordSalt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "PasswordSalt");
            DropColumn("dbo.Users", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Title", c => c.String(maxLength: 4000));
            AddColumn("dbo.Users", "PasswordSalt", c => c.String(maxLength: 4000));
        }
    }
}
