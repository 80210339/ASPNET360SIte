using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNET360SIte.Data;
using ASPNET360SIte.Models;

namespace ASPNET360SIte.Pages.FloorPlans
{
    public class DetailsModel : PageModel
    {
        private readonly ASPNET360SIte.Data.ApplicationDbContext _context;

        public DetailsModel(ASPNET360SIte.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public FloorPlan FloorPlan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FloorPlan = await _context.FloorPlan.FirstOrDefaultAsync(m => m.ID == id);
            //FloorPlan = await _context.FloorPlan.FirstOrDefaultAsync(m => m.CustomPropertyID == id);


            if (FloorPlan == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
