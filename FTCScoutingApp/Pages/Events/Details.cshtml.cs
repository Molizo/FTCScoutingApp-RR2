using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly AppDataContext _context;

        public DetailsModel(AppDataContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id);

            if (Event == null) return NotFound();
            return Page();
        }
    }
}