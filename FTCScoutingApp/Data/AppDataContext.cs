using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FTCScoutingApp.Models;

namespace FTCScoutingApp.Models
{
    public class AppDataContext : DbContext
    {
        public AppDataContext (DbContextOptions<AppDataContext> options)
            : base(options)
        {
        }

        public DbSet<FTCScoutingApp.Models.Team> Team { get; set; }

        public DbSet<FTCScoutingApp.Models.Event> Event { get; set; }

        public DbSet<FTCScoutingApp.Models.Match> Match { get; set; }
    }
}
