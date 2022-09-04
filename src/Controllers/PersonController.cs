using Microsoft.AspNetCore.Mvc;
using src.Models;
using System.Collections.Generic;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase 
{
    [HttpGet]
    public List<Person> Get() {
        List<Person> persons = new List<Person>();
        Contract c1 = new Contract();
        Contract c2 = new Contract(50, "00001");

        persons.Add(new Person("Felipe", 19, "93372755049"));
        persons.Add(new Person("Gabriel", 16, "54377865650"));

        persons[0].Contracts.Add(c1);
        persons[0].Contracts.Add(c2);

        return persons;
    }

    [HttpPost]
    public Person Post(Person person){
        return person;
    }

    [HttpPut("{id}")]
    public string Update(int id) {
        return $"Id data {id} update";
    }

    [HttpDelete("{id}")]
    public string Delete(int id) {
        return $"Person {id} deleted";
    }
}