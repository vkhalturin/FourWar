using System.Collections.Generic;

namespace N.FourWar.Foursquare.Domain
{
    public class RootObject
    {
        public Meta meta { get; set; }
        public List<Notification> notifications { get; set; }
        public Response response { get; set; }
    }
}