using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD.WEB.Model;

namespace CRUD.WEB.Data
{
    public class CRUDWEBContext : DbContext
    {
        public CRUDWEBContext (DbContextOptions<CRUDWEBContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD.WEB.Model.User> User { get; set; } = default!;
    }
}
