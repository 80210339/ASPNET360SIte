using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPNET360SIte.Models; using ASPNET360SIte.Data;
using System.IO;
//@using Microsoft.AspNetCore.Identity
using ASPNET360SIte.Areas.Identity.Data;
//@inject SignInManager<ApplicationUser> SignInManager
//@inject UserManager<ApplicationUser> UserManager


namespace ASPNET360SIte.Pages.Properties
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ASPNET360SIte.Models.Property Property { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var path = Path.Combine(
            Directory.GetCurrentDirectory(), "wwwroot/uploads",
            Property.MainImage.FileName);
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await Property.MainImage.CopyToAsync(stream);
                Property.MainImagePath = Property.MainImage.FileName;
            }

            Property.CustomAgentID = User.Identity.Name;

            _context.Property.Add(Property);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}