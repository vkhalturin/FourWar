using System.Collections.Generic;

namespace N.FourWar.Foursquare.Domain
{
    public class Item3
    {
        public string id { get; set; }
        public string name { get; set; }
        public Contact3 contact { get; set; }
        public Location2 location { get; set; }
        public List<Category> categories { get; set; }
        public bool verified { get; set; }
        public Stats stats { get; set; }
        public Likes likes { get; set; }
        public BeenHere beenHere { get; set; }
    }
}