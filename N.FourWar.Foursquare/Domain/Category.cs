using System.Collections.Generic;

namespace N.FourWar.Foursquare.Domain
{
    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pluralName { get; set; }
        public string shortName { get; set; }
        public string icon { get; set; }
        public List<string> parents { get; set; }
        public bool primary { get; set; }
    }
}