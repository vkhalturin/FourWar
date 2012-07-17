namespace N.FourWar.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users_AddColumn_Title : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Title", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Title");
        }
    }
}
