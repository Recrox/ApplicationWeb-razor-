using Core.Models;
using Data;

namespace Buisness.Concretes;

public class PersonDomain: IPersonDomain
{
    private IPersonRepository personRepository;

    public PersonDomain(IPersonRepository personRepository)
    {
        this.personRepository = personRepository;
    }

    public void CreatePerson(Person person)
    {
        this.personRepository.CreatePerson(person);
    }

    public void DeletePersonById(int id)
    {
        this.personRepository.DeletePersonById(id);
    }

    public Person GetPersonById(int id)
    {
        return this.personRepository.GetPersonById(id);
    }

    public IEnumerable<Person> GetPersonList()
    {
        return this.personRepository.GetPersonList();
    }

    public void UpdatePerson(Person person)
    {
        this.personRepository.UpdatePerson(person);
    }
}
