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

            _context.Team.Add(Team);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}