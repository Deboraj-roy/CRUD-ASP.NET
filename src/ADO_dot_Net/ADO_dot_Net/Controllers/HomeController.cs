using ADO_dot_Net.Controllers;
using ADO_dot_Net.Data;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("v3/[controller]")]
public class HomeController : ControllerBase
{
     PersonRepository _personRepository;

    public HomeController()
    {
        _personRepository = new PersonRepository();
    }

    //private readonly ILogger<HomeController> _logger;
    //public HomeController(ILogger<HomeController> logger) => _logger = logger;
    [HttpGet]

    public IActionResult Get()
    {
        var persons = _personRepository.GetPeople();
        return Ok(persons);
    }
}