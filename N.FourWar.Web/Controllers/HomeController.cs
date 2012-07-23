using System.Linq;
using System.Web.Mvc;
using N.FourWar.Db;
using N.FourWar.Db.Entities;
using N.FourWar.Web.Models;
using Neverov.Framework;

namespace N.FourWar.Web.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult User()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult User(UserModel userModel)
        {
            Option<User> user;
            using (var context = new FourWarContext())
            {
                user = Option.Some(context.Users.FirstOrDefault(u => u.FoursquareId == userModel.Id));
            }
            if (user.None)
            {
                return Json("User not found");
            }
            return Json("user found");
        }
    }
}