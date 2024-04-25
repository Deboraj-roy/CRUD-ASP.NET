using Microsoft.AspNetCore.Mvc;
using MVC.CRUD.Data;
using MVC.CRUD.Models;

namespace MVC.CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //IEnumerable<Employee> objEmployeeList = _db.Employees;
            //List<Employee> objEmployeeList1 = _db.Employees.ToList();
            var objEmployeeList = _db.Employees.ToList();
            return View(objEmployeeList);
        }
    }
}
