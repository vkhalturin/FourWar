using System.Collections.Generic;

namespace N.FourWar.Foursquare.Domain
{
    public class Image
    {
        public string prefix { get; set; }
        public List<int> sizes { get; set; }
        public string name { get; set; }
    }
}