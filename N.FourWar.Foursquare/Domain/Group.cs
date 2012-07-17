using System.Collections.Generic;

namespace N.FourWar.Foursquare.Domain
{
    public class Group
    {
        public string type { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public List<object> items { get; set; }
    }
}