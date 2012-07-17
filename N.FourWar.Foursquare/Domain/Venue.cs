using System.Collections.Generic;

namespace N.FourWar.Foursquare.Domain
{
    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public Contact2 contact { get; set; }
        public Location location { get; set; }
        public List<Category> categories { get; set; }
        public bool verified { get; set; }
        public Stats stats { get; set; }
        public string url { get; set; }
        public Likes likes { get; set; }
        public BeenHere beenHere { get; set; }
    }
}