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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            //if (obj.DateOfBirth == obj.JoinDate)
            //{
            //    ModelState.AddModelError("JoinDate", "The Join Date cannot exactly match the DateOfBirth.");
            //}

            if (ModelState.IsValid)
            {
                _db.Employees.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
        
        public IActionResult Edit(Guid? id)
        {
            if (id == null || id == Guid.Empty) { return NotFound(); }
            //Employee employee = _db.Employees.Find(id);
            Employee employee = _db.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null) { return NotFound(); }
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee obj)
        {  
            if (ModelState.IsValid)
            {
                _db.Employees.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(Guid? id)
        {
            if (id == null || id == Guid.Empty) { return NotFound(); }
            //Employee employee = _db.Employees.Find(id);
            Employee employee = _db.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null) { return NotFound(); }
            return View(employee);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(Guid? id)
        {
            if (id == null || id == Guid.Empty) { return NotFound(); }
            //Employee employee = _db.Employees.Find(id);
            Employee employee = _db.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null) { return NotFound(); }

            _db.Employees.Remove(employee);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
