using System.Linq;
using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Pages.Teams
{
    public class EditModel : PageModel
    {
        private readonly AppDataContext _context;

        public EditModel(AppDataContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                if (User.Identity.IsAuthenticated)
                    return Page();
                return RedirectToPage("/Error");
            }

            _context.Attach(Team).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(Team.ID))
                    return NotFound();
                throw;
            }

            return RedirectToPage("./Index");
        }

        private bool TeamExists(int id)
        {
            return _context.Team.Any(e => e.ID == id);
        }
    }
}