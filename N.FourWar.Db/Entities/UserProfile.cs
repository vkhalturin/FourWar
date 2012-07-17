using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N.FourWar.Db.Entities
{
    public class Characteristics
    {
        [Key]
        public long Id { get; set; }

        public long Experience { get; set; }

        [Required]
        public virtual User User { get; set; }
    }
}
