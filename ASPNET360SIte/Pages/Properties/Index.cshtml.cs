using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNET360SIte.Models; using ASPNET360SIte.Data;

namespace ASPNET360SIte.Pages.Properties
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ASPNET360SIte.Models.Property> Property { get;set; }

        public async Task OnGetAsync()
        {
            Property = await _context.Property.Where(x => x.CustomAgentID == User.Identity.Name).ToListAsync();
        }
    }
}
