using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Data;
using MVC_Project.Models;

namespace MVC_Project.Views.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly MVC_Project.Data.MVC_ProjectContext _context;

        public DeleteModel(MVC_Project.Data.MVC_ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employe Employe { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employe = await _context.Employe.FirstOrDefaultAsync(m => m.Id == id);

            if (employe == null)
            {
                return NotFound();
            }
            else
            {
                Employe = employe;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employe = await _context.Employe.FindAsync(id);
            if (employe != null)
            {
                Employe = employe;
                _context.Employe.Remove(Employe);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
