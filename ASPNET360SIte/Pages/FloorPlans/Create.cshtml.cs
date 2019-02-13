using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPNET360SIte.Data;
using ASPNET360SIte.Models;

namespace ASPNET360SIte.Pages.FloorPlans
{
    public class CreateModel : PageModel
    {
        private readonly ASPNET360SIte.Data.ApplicationDbContext _context;

        public CreateModel(ASPNET360SIte.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FloorPlan FloorPlan { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FloorPlan.Add(FloorPlan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}