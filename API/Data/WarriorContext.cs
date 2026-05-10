using Microsoft.EntityFrameworkCore;
using Models;

namespace DamageAPI.Data
{
    public class WarriorContext(DbContextOptions<WarriorContext> options) : DbContext(options)
    {
        public DbSet<Warrior> Warriors { get; set; }
    }
}
