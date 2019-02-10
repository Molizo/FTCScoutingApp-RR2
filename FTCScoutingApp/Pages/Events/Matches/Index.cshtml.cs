﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FTCScoutingApp.Models;

namespace FTCScoutingApp.Pages.Events.Matches
{
    public class IndexModel : PageModel
    {
        private readonly FTCScoutingApp.Models.AppDataContext _context;

        public IndexModel(FTCScoutingApp.Models.AppDataContext context)
        {
            _context = context;
        }

        public IList<Match> Match { get;set; }

        public async Task OnGetAsync()
        {
            Match = await _context.Match.ToListAsync();
        }
    }
}