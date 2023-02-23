using AutoMapper;
using Core.Models;
using Data;

namespace Providers.Sql.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly WebAppPeopleContext context;
    private readonly IMapper mapper;

    public PersonRepository(WebAppPeopleContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    public void CreatePerson(Person person)
    {
        /*var newPerson = new Models.Person()
        {
            FirstName = person.FirstName,
            LastName = person.LastName,
            IsAlive = person.IsAlive,
            Age = person.Age,
        };*/
        this.context.Person.Add(this.mapper.Map<Person, Models.Person>(person));
        this.context.SaveChanges();
    }

    public void DeletePersonById(int id)
    {
        var person = this.context.Person.Find(id);
        this.context.Person.Remove(person);
        this.context.SaveChanges();
        
    }

    public Person GetPersonById(int id)
    {
        return this.mapper.Map<Person>( this.context.Person.Find(id));
    }

    public IEnumerable<Person> GetPersonList()
    {
        /*return this.context.Person.Select(person => new Person()
        {
            Id = person.Id,
            FirstName = person.FirstName,
            LastName = person.LastName,
            IsAlive = person.IsAlive,
            Age = person.Age
        });*/

        return this.mapper.Map<IEnumerable<Person>>(this.context.Person);
    }

    public void UpdatePerson(Person person)
    {
        /*this.context.Person.Update(new Models.Person()
        {
            Id = person.Id,
            FirstName = person.FirstName,
            LastName = person.LastName,
            Age = person.Age,
            IsAlive = person.IsAlive,
        });*/
        this.context.Person.Update(this.mapper.Map<Models.Person>(person));  
        this.context.SaveChanges();
    }
}