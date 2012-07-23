namespace N.FourWar.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FoursquareId = c.Long(),
                        OAuthToken = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                        PasswordHash = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Characteristics",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Experience = c.Long(nullable: false),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Characteristics", new[] { "Id" });
            DropIndex("dbo.Characteristics", new[] { "User_Id" });
            DropForeignKey("dbo.Characteristics", "Id", "dbo.Users");
            DropForeignKey("dbo.Characteristics", "User_Id", "dbo.Users");
            DropTable("dbo.Characteristics");
            DropTable("dbo.Users");
        }
    }
}
