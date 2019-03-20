using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FTCScoutingApp.Pages.Teams
{
    public class CreateModel : PageModel
    {
        private readonly AppDataContext _context;

        public CreateModel(AppDataContext context)
        {
            _context = context;
        }

        [BindProperty] public Team Team { get; set; }

        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated)
                return Page();
            return RedirectToPage("/Error");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            Team.AllowedUserIDs = User.Identity.Name;

            Team.ExPts = 0;
            if(Team.Latched == true)
                Team.ExPts += 30;
            if(Team.Sampling == true)
                Team.ExPts += 25;
            if(Team.TeamMarker == true)
                Team.ExPts += 15;
            if(Team.Parking == true)
                Team.ExPts += 10;
            if(Team.EndLocation.ToLower().Contains("latched"))
                Team.ExPts += 50;
            else if(Team.EndLocation.ToLower().Contains("partial"))
                Team.ExPts += 15;
            else if(Team.EndLocation.ToLower().Contains("full"))
                Team.ExPts += 25;
            Team.ExPts += Team.DepotMinerals * 2;
            Team.ExPts += Team.GoldMinerals * 5;
            Team.ExPts += Team.SilverMinerals * 5;

            _context.Team.Add(Team);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}