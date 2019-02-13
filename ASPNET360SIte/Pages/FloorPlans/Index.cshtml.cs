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
    public class IndexModel : PageModel
    {
        private readonly ASPNET360SIte.Data.ApplicationDbContext _context;

        public IndexModel(ASPNET360SIte.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<FloorPlan> FloorPlan { get;set; }

        public async Task OnGetAsync()
        {
            FloorPlan = await _context.FloorPlan.ToListAsync();

            //FloorPlan = await _context.FloorPlan.Where(x => x.CustomPropertyID == ID).ToListAsync();
        }
    }
}
