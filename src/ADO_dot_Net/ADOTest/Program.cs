// See https://aka.ms/new-console-template for more information
using ADOTest.Data;

Console.WriteLine("Hello, World!");

PersonRepository personRepository = new PersonRepository();
List<Person> people = personRepository.GetPeople();
foreach (Person person in people)
{
    Console.WriteLine(person.Name + " " + person.Email);
}

Person personById = personRepository.PersonById(1);
Console.WriteLine(personById.Name + " " + personById.Email);

personRepository.CreatePerson(new Person
{
    Name = "ttt",
    Email = "j@j.com",
    Address = "123 Main St",
    Phone = "555-555-5555",
    Salary = 1000
});

personRepository.UpdatePerson(new Person
{
    Id = 1,
    Name = "John",
    Email = "johndoe@example.com",
    Address = "123 Main St",
    Phone = "555-555-5555",
    Salary = 1000
});

personRepository.DeletePerson(6);

Console.WriteLine("Hello, World!");
