using System.Collections.Generic;

namespace N.FourWar.Foursquare.Domain
{
    public class Item2
    {
        public string id { get; set; }
        public string badgeId { get; set; }
        public string name { get; set; }
        public string unlockMessage { get; set; }
        public string description { get; set; }
        public string badgeText { get; set; }
        public Image image { get; set; }
        public List<Unlock> unlocks { get; set; }
    }
}