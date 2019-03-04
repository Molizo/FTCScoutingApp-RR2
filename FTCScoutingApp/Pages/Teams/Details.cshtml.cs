using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Pages.Teams
{
    public class DetailsModel : PageModel
    {
        private readonly AppDataContext _context;

        public DetailsModel(AppDataContext context)
        {
            _context = context;
        }

        public Team Team { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Team = await _context.Team.FirstOrDefaultAsync(m => m.ID == id);

            if (Team == null) return NotFound();

            if (User.Identity.IsAuthenticated)
                return Page();
            return RedirectToPage("/Error");
        }
    }
}