using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Models
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options)
        {
        }

        public DbSet<Team> Team { get; set; }

        public DbSet<Event> Event { get; set; }

        public DbSet<Match> Match { get; set; }
    }
}