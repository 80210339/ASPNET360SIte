﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNET360SIte.Models;

namespace ASPNET360SIte.Pages.Properties
{
    public class DetailsModel : PageModel
    {
        private readonly ASPNET360SIte.Models.ASPNET360SIteContext _context;

        public DetailsModel(ASPNET360SIte.Models.ASPNET360SIteContext context)
        {
            _context = context;
        }

        public ASPNET360SIte.Models.Property Property { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*Property = await _context.Property.FirstOrDefaultAsync(m => m.ID == id);*/
            Property = await _context.Property.FirstOrDefaultAsync(m => m.ID == id);

            /*            Property = await _context.Property
                    .Include(s => s.FloorPlan)
                        .ThenInclude(e => e.Room)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(m => m.ID == id);
            */
            if (Property == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
