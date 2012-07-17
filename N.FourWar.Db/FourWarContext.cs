using System.Data.Entity;
using N.FourWar.Db.Entities;

namespace N.FourWar.Db
{
    public class FourWarContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
