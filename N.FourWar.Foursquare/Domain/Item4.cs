namespace N.FourWar.Foursquare.Domain
{
    public class Item4
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public string type { get; set; }
        public bool isMayor { get; set; }
        public string timeZone { get; set; }
        public int timeZoneOffset { get; set; }
        public Venue2 venue { get; set; }
        public Likes likes { get; set; }
        public bool like { get; set; }
        public Photos photos { get; set; }
        public Comments comments { get; set; }
        public Source source { get; set; }
    }
}