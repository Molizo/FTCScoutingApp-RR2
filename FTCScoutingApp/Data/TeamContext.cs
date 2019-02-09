using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext (DbContextOptions<TeamContext> options)
            : base(options)
        {
        }

        public DbSet<FTCScoutingApp.Models.Team> Team { get; set; }
    }
}
