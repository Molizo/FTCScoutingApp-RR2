using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FTCScoutingApp.Models;

namespace FTCScoutingApp.Pages.Events.Matches
{
    public class DeleteModel : PageModel
    {
        private readonly FTCScoutingApp.Models.AppDataContext _context;

        public DeleteModel(FTCScoutingApp.Models.AppDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Match Match { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Match = await _context.Match.FirstOrDefaultAsync(m => m.ID == id);

            if (Match == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Match = await _context.Match.FindAsync(id);

            if (Match != null)
            {
                _context.Match.Remove(Match);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
