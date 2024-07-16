using ADO_dot_Net.Data;
using Microsoft.AspNetCore.Mvc;

namespace ADO_dot_Net.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController2 : ControllerBase
    {
        private readonly PersonRepository _personRepository;
        private readonly ILogger<WeatherForecastController> _logger;

        public HomeController2(ILogger<WeatherForecastController> logger, PersonRepository personRepository)
        {
            _logger = logger;
            _personRepository = personRepository;
        } 

        public IActionResult Index()
        {
            var persons = _personRepository.GetPeople();
            return Ok(persons);
        }
    }
}
