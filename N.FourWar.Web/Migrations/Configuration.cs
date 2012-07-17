using N.FourWar.Db;

namespace N.FourWar.Web.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FourWarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FourWarContext context)
        {
       
        }
    }
}
