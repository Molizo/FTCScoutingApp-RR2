using System.Linq;
using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Pages.Events.Matches
{
    public class EditModel : PageModel
    {
        private readonly AppDataContext _context;

        public EditModel(AppDataContext context)
        {
            _context = context;
        }

        [BindProperty] public Match Match { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Match = await _context.Match.FirstOrDefaultAsync(m => m.ID == id);

            if (Match == null) return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            _context.Attach(Match).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatchExists(Match.ID))
                    return NotFound();
                throw;
            }

            return RedirectToPage("./Index");
        }

        private bool MatchExists(int id)
        {
            return _context.Match.Any(e => e.ID == id);
        }
    }
}