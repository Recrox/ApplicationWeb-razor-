using Core.Models;

namespace Buisness.Concretes;

public interface IPersonDomain
{
    public IEnumerable<Person> GetPersonList();
    Person GetPersonById(int id);
    void CreatePerson(Person person);
    void UpdatePerson(Person person);
    void DeletePersonById(int id);
}