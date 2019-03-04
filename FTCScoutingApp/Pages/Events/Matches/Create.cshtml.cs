using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FTCScoutingApp.Pages.Events.Matches
{
    public class CreateModel : PageModel
    {
        private readonly AppDataContext _context;

        public CreateModel(AppDataContext context)
        {
            _context = context;
        }

        [BindProperty] public Match Match { get; set; }

        [BindProperty] public IList<Team> Team { get; set; }

        public IActionResult OnGet()
        {
            Team = _context.Team.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            _context.Match.Add(Match);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}