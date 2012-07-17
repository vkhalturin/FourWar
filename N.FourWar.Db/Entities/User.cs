using System.ComponentModel.DataAnnotations;

namespace N.FourWar.Db.Entities
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        public long FoursquareId { get; set; }
            
        public string OAuthToken { get; set; }

        public string Name { get; set; }

        public string PasswordHash { get; set; }

        public virtual Characteristics Characteristics { get; set; }
    }
}
