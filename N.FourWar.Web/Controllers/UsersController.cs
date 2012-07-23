using System.Collections.Generic;
using System.Web.Mvc;
using Igloo.SharpSquare.Core;
using Igloo.SharpSquare.Entities;
using N.FourWar.Foursquare;

namespace N.FourWar.Web.Controllers
{
    public partial class UsersController : Controller
    {
        public virtual ActionResult Login()
        {
            var api = new SharpSquare(Const.ClientId, Const.ClientSecret);
            var authenticateUrl = api.GetAuthenticateUrl(Const.RedirectUrl);
            string token = api.GetAccessToken(Const.RedirectUrl, "wazzup");
            List<Checkin> checkins = api.GetRecentCheckin();
            return Json(checkins);
        }

        public virtual ActionResult LoginFoursquare()
        {
            var api = new SharpSquare(Const.ClientId, Const.ClientSecret);
            var authenticateUrl = api.GetAuthenticateUrl(Request.UrlReferrer.ToString());
            return Redirect(authenticateUrl);
        }
    }
}