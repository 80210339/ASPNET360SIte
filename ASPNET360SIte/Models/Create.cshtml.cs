using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
//using ASPNET360SIte.Models.IdentityCustomisationTest.Models;
using System.IO;

namespace ASPNET360SIte.Models
{
    public class CreateModel : PageModel
    {
        private readonly ASPNET360SIte.Models.ASPNET360SIteContext _context;

        public CreateModel(ASPNET360SIte.Models.ASPNET360SIteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ASPNET360SIte.Models.Property Property { get; set; }

        /* --Original code generate for us, replacing with below example from tutor notes 
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Property.Add(Property);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        */


        /* (C:)	Add upload functionality to Create.cshtml.cs code-behind file  – update the OnPostAsync() method and resolve the errors by adding missing “using” statements.*/
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

            _context.Property.Add(Property);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}