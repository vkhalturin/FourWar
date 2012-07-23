using System.Data.Entity.Migrations;

namespace N.FourWar.Db.Migrations
{
    public partial class Characteristics_ColumnRename_Experience_To_Exp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characteristics", "Exp", c => c.Long(nullable: false));
            // transfer data            
            Sql("UPDATE Characteristics SET Exp = Experience");
            DropColumn("dbo.Characteristics", "Experience");
        }

        public override void Down()
        {
            AddColumn("dbo.Characteristics", "Experience", c => c.Long(nullable: false));
            // transfer data
            Sql("UPDATE Characteristics SET Experience = Exp");
            DropColumn("dbo.Characteristics", "Exp");
        }
    }
}