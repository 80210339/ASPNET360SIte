using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPNET360SIte.Data;
using ASPNET360SIte.Models;

namespace ASPNET360SIte.Pages.FloorPlans
{
    public class EditModel : PageModel
    {
        private readonly ASPNET360SIte.Data.ApplicationDbContext _context;

        public EditModel(ASPNET360SIte.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FloorPlan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FloorPlanExists(FloorPlan.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FloorPlanExists(int id)
        {
            return _context.FloorPlan.Any(e => e.ID == id);
        }
    }
}
