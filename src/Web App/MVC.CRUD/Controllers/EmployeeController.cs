using Microsoft.AspNetCore.Mvc;

namespace MVC.CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
