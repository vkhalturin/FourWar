namespace N.FourWar.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users_AddColumn_FoursquareId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FoursquareId", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "FoursquareId");
        }
    }
}
