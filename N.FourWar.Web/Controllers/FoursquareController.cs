using System.IO;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Igloo.SharpSquare.Core;
using N.FourWar.Foursquare;

namespace N.FourWar.Web.Controllers
{
    public partial class FoursquareController : Controller
    {
        public virtual ActionResult Authenticate()
        {
            var api = new SharpSquare(Const.ClientId, Const.ClientSecret);
            var authenticateUrl = api.GetAuthenticateUrl(Const.RedirectUrl);
            return Redirect(authenticateUrl);
        }

        public virtual ActionResult Authorize(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return Json("Failed to authenticate");
            }
            var api = new SharpSquare(Const.ClientId, Const.ClientSecret);
            var tokenUrl = api.GetAccessToken(Const.RedirectUrl, code);
            var request =  WebRequest.Create(tokenUrl) as HttpWebRequest;
            using (var response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var responseJson = reader.ReadToEnd();
                    return Json(responseJson);
                }
            }
        }
    }
}