using Microsoft.EntityFrameworkCore;
using Models;

namespace DamageAPI.Data
{
    public class WarriorDbContext(DbContextOptions<WarriorDbContext> options) : DbContext(options)
    {
        public DbSet<Warrior> Warriors { get; set; }
    }
}
