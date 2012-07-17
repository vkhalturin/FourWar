using System.ComponentModel.DataAnnotations;

namespace N.FourWar.Db.Entities
{
    public class Characteristics
    {
        [Key]
        public long Id { get; set; }

        public long Experience { get; set; }

        public virtual User User { get; set; }
    }
}
