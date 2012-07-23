using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using N.FourWar.Db;

namespace N.FourWar.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RegisterDatabase();
            InitDatabase();
            CheckDatabase();
        }

        private void InitDatabase()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<FourWarContext>());
        }

        private void CheckDatabase()
        {
            try
            {
                using (var context = new FourWarContext())
                {
                    var user = context.Users.FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                throw new HttpException((int) HttpStatusCode.NotFound, "Database is unavailable", e);
            }
        }

        private void RegisterDatabase()
        {
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
        }
    }
}