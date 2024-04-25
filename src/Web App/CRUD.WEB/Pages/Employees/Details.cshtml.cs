using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD.WEB.Data;
using CRUD.WEB.Model;

namespace CRUD.WEB.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly CRUD.WEB.Data.CRUDWEBContext _context;

        public DetailsModel(CRUD.WEB.Data.CRUDWEBContext context)
        {
            _context = context;
        }

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
    }
}
