using System.Collections.Generic;

namespace N.FourWar.Foursquare.Domain
{
    public class Venue2
    {
        public string id { get; set; }
        public string name { get; set; }
        public Contact3 contact { get; set; }
        public Location3 location { get; set; }
        public List<Category> categories { get; set; }
        public bool verified { get; set; }
        public Stats stats { get; set; }
        public Likes likes { get; set; }
        public bool like { get; set; }
        public FriendVisits friendVisits { get; set; }
        public BeenHere3 beenHere { get; set; }
        public Listed listed { get; set; }
    }
}