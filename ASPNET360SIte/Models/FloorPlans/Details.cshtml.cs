using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNET360SIte.Models;

namespace ASPNET360SIte.Pages.FloorPlans
{
    public class DetailsModel : PageModel
    {
        private readonly ASPNET360SIte.Models.ASPNET360SIteContext _context;

        public DetailsModel(ASPNET360SIte.Models.ASPNET360SIteContext context)
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

            if (FloorPlan == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
