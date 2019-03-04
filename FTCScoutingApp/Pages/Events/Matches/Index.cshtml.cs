using System.Collections.Generic;
using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Pages.Events.Matches
{
    public class IndexModel : PageModel
    {
        private readonly AppDataContext _context;

        public IndexModel(AppDataContext context)
        {
            _context = context;
        }

        public IList<Match> Match { get; set; }

        public async Task OnGetAsync()
        {
            Match = await _context.Match.ToListAsync();
        }
    }
}