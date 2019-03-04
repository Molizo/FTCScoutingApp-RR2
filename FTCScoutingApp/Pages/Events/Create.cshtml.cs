using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FTCScoutingApp.Pages.Events
{
    public class CreateModel : PageModel
    {
        private readonly AppDataContext _context;

        public CreateModel(AppDataContext context)
        {
            _context = context;
        }

        [BindProperty] public Event Event { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            _context.Event.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}