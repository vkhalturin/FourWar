using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using N.FourWar.Db;
using N.FourWar.Foursquare;
using N.FourWar.Foursquare.Domain;
using N.FourWar.Web.Models;
using User = N.FourWar.Db.Entities.User;

namespace N.FourWar.Web.Controllers
{
    public partial class HomeController : Controller
    {
        private const string ApiUrl = "https://api.foursquare.com/v2";

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
            User user;
            using (var context = new FourWarContext())
            {
                user = context.Users.FirstOrDefault(u => u.FoursquareId == userModel.Id);
            }
            if (user == null)
            {
                return Json("User not found");
            }
            string url = string.Format("{0}/users/{1}",
                                       ApiUrl,
                                       user.FoursquareId);
            var api = new FoursquareApi();
            string urlWithAuth = api.AddAuthToken(url, user.OAuthToken);
            HttpWebRequest request = WebRequest.CreateHttp(urlWithAuth);
            using (WebResponse response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var serializer = new JavaScriptSerializer();
                    string jsonString = reader.ReadToEnd();
                    var json = serializer.Deserialize<RootObject>(jsonString);
                    
                    return Json(json);
                }
            }
        }
    }
}