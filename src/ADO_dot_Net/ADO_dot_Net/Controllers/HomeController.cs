//using ADO_dot_Net.Data;
//using Microsoft.AspNetCore.Mvc;

//[ApiController]
//[Route("v3/[controller]")]
//public class HomeController : ControllerBase
//{
//    private readonly PersonRepository _personRepository;

//    public HomeController(PersonRepository personRepository)
//    {
//        _personRepository = personRepository;
//    }

//    public IActionResult Index()
//    {
//        var persons = _personRepository.GetPeople();
//        return Ok(persons);
//    }
//}