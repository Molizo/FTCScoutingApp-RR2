using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Pages.Events.Matches
{
    public class DetailsModel : PageModel
    {
        private readonly AppDataContext _context;

        public DetailsModel(AppDataContext context)
        {
            _context = context;
        }

        public Match Match { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Match = await _context.Match.FirstOrDefaultAsync(m => m.ID == id);

            if (Match == null) return NotFound();
            return Page();
        }
    }
}