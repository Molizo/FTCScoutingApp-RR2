using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Pages.Teams
{
    public class DeleteModel : PageModel
    {
        private readonly AppDataContext _context;

        public DeleteModel(AppDataContext context)
        {
            _context = context;
        }

        [BindProperty] public Team Team { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Team = await _context.Team.FirstOrDefaultAsync(m => m.ID == id);

            if (Team == null) return NotFound();

            if (User.Identity.IsAuthenticated)
                return Page();
            return RedirectToPage("/Error");
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) return NotFound();

            Team = await _context.Team.FindAsync(id);

            if (Team != null)
            {
                _context.Team.Remove(Team);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}