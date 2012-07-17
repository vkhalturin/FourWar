using System.Collections.Generic;
using System.Web.Http;
using N.FourWar.Db;
using N.FourWar.Db.Entities;

namespace N.FourWar.Web.Controllers
{
    public class UsersController : ApiController
    {
        private readonly FourWarContext _context = new FourWarContext();

        // GET api/values
        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        // GET api/values/5
        public User Get(int id)
        {
            // todo get user from foursquare here

            return null;
        }

        // POST api/values
        public void Post(string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}