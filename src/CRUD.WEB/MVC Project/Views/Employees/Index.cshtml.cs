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
    public class IndexModel : PageModel
    {
        private readonly MVC_Project.Data.MVC_ProjectContext _context;

        public IndexModel(MVC_Project.Data.MVC_ProjectContext context)
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
