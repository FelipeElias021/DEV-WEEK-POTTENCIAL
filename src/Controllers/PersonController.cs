using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Persistence;
using Microsoft.EntityFrameworkCore;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase 
{
    private DatabaseContext _repository { get; set; }

    public PersonController(DatabaseContext context)
    {
        this._repository = context;
    }

    [HttpGet]
    public List<Person> Get() {
        return _repository.Persons.Include(p => p.Contracts).ToList();
    }

    [HttpPost]
    public Person Post([FromBody]Person person){
        _repository.Persons.Add(person);
        _repository.SaveChanges();
        return person;
    }

    [HttpPut("{id}")]
    public string Update([FromRoute]int id, [FromBody]Person person) {
        _repository.Persons.Update(person);
        _repository.SaveChanges();
        return $"Id data {id} update";
    }

    [HttpDelete("{id}")]
    public string Delete(int id, Person person) {
        _repository.Persons.Remove(person);
        _repository.SaveChanges();
        return $"Person {id}, {person.Name} deleted";
    }
}