using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FTCScoutingApp.Models;

namespace FTCScoutingApp.Pages.Teams
{
    public class CreateModel : PageModel
    {
        private readonly FTCScoutingApp.Models.TeamContext _context;

        public CreateModel(FTCScoutingApp.Models.TeamContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            if(User.Identity.IsAuthenticated)
                return Page();
            else
                return RedirectToPage("/Error");
        }

        [BindProperty]
        public Team Team { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Team.Add(Team);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}