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
    public class IndexModel : PageModel
    {
        private readonly CRUD.WEB.Data.CRUDWEBContext _context;

        public IndexModel(CRUD.WEB.Data.CRUDWEBContext context)
        {
            _context = context;
        }

        public IList<Employe> Employe { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employe = await _context.Employe.ToListAsync();
        }
    }
}
