using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FTCScoutingApp.Models;

namespace FTCScoutingApp.Pages.Teams
{
    public class DetailsModel : PageModel
    {
        private readonly FTCScoutingApp.Models.TeamContext _context;

        public DetailsModel(FTCScoutingApp.Models.TeamContext context)
        {
            _context = context;
        }

        public Team Team { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Team = await _context.Team.FirstOrDefaultAsync(m => m.ID == id);

            if (Team == null)
            {
                return NotFound();
            }

            if (User.Identity.IsAuthenticated)
                return Page();
            else
                return RedirectToPage("/Error");
        }
    }
}
