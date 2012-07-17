namespace N.FourWar.Foursquare.Domain
{
    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string relationship { get; set; }
        public string photo { get; set; }
        public Friends friends { get; set; }
        public string type { get; set; }
        public Tips tips { get; set; }
        public Lists lists { get; set; }
        public string gender { get; set; }
        public string homeCity { get; set; }
        public string bio { get; set; }
        public Contact contact { get; set; }
        public bool pings { get; set; }
        public Badges badges { get; set; }
        public Mayorships mayorships { get; set; }
        public Checkins checkins { get; set; }
        public Following following { get; set; }
        public Requests requests { get; set; }
        public Todos todos { get; set; }
        public Photos3 photos { get; set; }
        public Scores scores { get; set; }
    }
}