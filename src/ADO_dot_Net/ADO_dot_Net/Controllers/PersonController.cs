using ADO_dot_Net.Data;
using Microsoft.AspNetCore.Mvc;
namespace ADO_dot_Net.Controllers
{
    [ApiController]
    [Route("v3/[controller]")]
    public class PersonController : ControllerBase
    {
        PersonRepository personRepository;

        public PersonController()
        {
            personRepository = new PersonRepository();
        }
        [HttpGet]
        public IActionResult GetPeople()
        {
            var people = personRepository.GetPeople(); // <List<Person>>
            return Ok(people);
        }
        [HttpGet("{id}")]
        public IActionResult GetPersonById(int id)
        {
            Person person = personRepository.PersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
        //[HttpPost]
        //public IActionResult AddPerson(Person person)
        //{
        //    personRepository.CreatePerson(person);
        //    return CreatedAtRoute("DefaultApi", new { id = person.Id }, person); ;
        //}
        //[HttpPut]
        //public IActionResult UpdatePerson(int id, Person person)
        //{
        //    if (id != person.Id)
        //    {
        //        return BadRequest();
        //    }
        //    var personw = personRepository.PersonById(id);
        //    if (personw is not null)
        //    {
        //        personRepository.UpdatePerson(person);
        //        return Ok();
        //    }
        //    return NotFound();
        //}
        //[HttpDelete]
        //public IActionResult DeletePerson(int id)
        //{
        //    personRepository.DeletePerson(id);
        //    return Ok();
        //}
    }
}
