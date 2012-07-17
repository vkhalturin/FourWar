using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required]
        public virtual Characteristics Characteristics { get; set; }
    }
}
