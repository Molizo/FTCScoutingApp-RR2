using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FTCScoutingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Pages.Events.Matches
{
    public class CreateModel : PageModel
    {
        private readonly FTCScoutingApp.Models.AppDataContext _context;

        public CreateModel(FTCScoutingApp.Models.AppDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Team = _context.Team.ToList();
            return Page();
        }

        [BindProperty]
        public Match Match { get; set; }
        [BindProperty]
        public IList<Team> Team { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Match.Add(Match);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}