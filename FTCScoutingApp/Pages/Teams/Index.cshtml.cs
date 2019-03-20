using System.Collections.Generic;
using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly AppDataContext _context;

        public IndexModel(AppDataContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get; set; }

        public async Task OnGetAsync()
        {
            Team = await _context.Team.ToListAsync();
        }

    }
}