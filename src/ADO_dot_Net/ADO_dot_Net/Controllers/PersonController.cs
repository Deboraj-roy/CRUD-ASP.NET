using ADO_dot_Net.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
namespace ADO_dot_Net.Controllers
{
    [Route("api/Person")]
    [ApiController] 
    public class PersonController : ControllerBase
    {
        private PersonRepository personRepository { get; set; }

        public PersonController()
        { 
            personRepository = new PersonRepository();
        }
        public IActionResult GetPeople()
        { 
            List<Person> people = personRepository.GetPeople(); // <List<Person>>
            return Ok(people);
        }

        public IActionResult GetPersonById(int id)
        {
            Person person = personRepository.PersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        public IActionResult AddPerson(Person person)
        {
            personRepository.CreatePerson(person);
            return CreatedAtRoute("DefaultApi", new { id = person.Id }, person); ;
        }

        public IActionResult UpdatePerson(int id, Person person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }
            var personw = personRepository.PersonById(id);
            if (personw is not null)
            { 
            personRepository.UpdatePerson(person);
            return Ok();
            }
            return NotFound();
        }
        public IActionResult DeletePerson(int id)
        {
            personRepository.DeletePerson(id);
            return Ok();
        }
    }
}
