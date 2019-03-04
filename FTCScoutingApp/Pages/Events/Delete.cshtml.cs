﻿using System.Threading.Tasks;
using FTCScoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FTCScoutingApp.Pages.Events
{
    public class DeleteModel : PageModel
    {
        private readonly AppDataContext _context;

        public DeleteModel(AppDataContext context)
        {
            _context = context;
        }

        [BindProperty] public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id);

            if (Event == null) return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) return NotFound();

            Event = await _context.Event.FindAsync(id);

            if (Event != null)
            {
                _context.Event.Remove(Event);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}