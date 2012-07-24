using System.Web.Mvc;
using Igloo.SharpSquare.Core;
using N.FourWar.Db;

namespace N.FourWar.Web.Controllers
{
    public partial class FoursquareController : Controller
    {
        // todo obfuscation and security
        public const string ClientId = "HEOR4Q1AJROG1E03CSOQGJOHFV2CRU0EKUFMPCIFPQ5BUXHK";
        public const string ClientSecret = "CH5LLFSJJYA1FDZ3VIPJIDWD30TLR5OMHYOI2VX5G5S245HD";
        public const string RedirectUrl = "http://localhost:3038/foursquare/authorize/";

        public virtual ActionResult Authenticate()
        {
            var api = new SharpSquare(ClientId, ClientSecret);
            string authenticateUrl = api.GetAuthenticateUrl(RedirectUrl);
            return Redirect(authenticateUrl);
        }

        public virtual ActionResult Authorize(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return Json("Failed to authenticate");
            }
            var api = new SharpSquare(ClientId, ClientSecret);
            string token = api.GetAccessToken(RedirectUrl, code);
            api.SetAccessToken(token);
            var user = api.GetUser("self");
            // todo store token to user
            using(var context = new FourWarContext())
            {
                /*
                var user = context.Users.Create();
                user.OAuthToken = token;
                user
                 * */
            }
            return RedirectToAction(MVC.Home.Index());
        }
    }
}