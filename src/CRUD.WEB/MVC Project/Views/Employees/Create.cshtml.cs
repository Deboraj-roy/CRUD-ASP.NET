using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Project.Data;
using MVC_Project.Models;

namespace MVC_Project.Views.Employees
{
    public class CreateModel : PageModel
    {
        private readonly MVC_Project.Data.MVC_ProjectContext _context;

        public CreateModel(MVC_Project.Data.MVC_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employe Employe { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employe.Add(Employe);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
