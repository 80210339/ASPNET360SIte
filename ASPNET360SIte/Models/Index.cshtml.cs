using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASPNET360SIte.Models
{
    public class IndexModel : PageModel
    {
        private readonly ASPNET360SIte.Models.ASPNET360SIteContext _context;

        public IndexModel(ASPNET360SIte.Models.ASPNET360SIteContext context)
        {
            _context = context;
        }

        public IList<ASPNET360SIte.Models.Property> Property { get;set; }

        public async Task OnGetAsync()
        {
            Property = await _context.Property.ToListAsync();

            foreach (var x in Property)
            {
                x.CustomAgentID = User.Identity.Name;
            }
        }
    }
}
