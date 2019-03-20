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
            Team.ExPts = 0;
            if (Team.Latched == true)
                Team.ExPts += 30;
            if (Team.Sampling == true)
                Team.ExPts += 25;
            if (Team.TeamMarker == true)
                Team.ExPts += 15;
            if (Team.Parking == true)
                Team.ExPts += 10;
            if (Team.EndLocation.ToLower().Contains("latched"))
                Team.ExPts += 50;
            else if (Team.EndLocation.ToLower().Contains("partial"))
                Team.ExPts += 15;
            else if (Team.EndLocation.ToLower().Contains("full"))
                Team.ExPts += 25;
            Team.ExPts += Team.DepotMinerals * 2;
            Team.ExPts += Team.GoldMinerals * 5;
            Team.ExPts += Team.SilverMinerals * 5;

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