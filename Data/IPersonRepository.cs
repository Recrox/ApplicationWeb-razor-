using Core.Models;

namespace Data;

public interface IPersonRepository
{
    IEnumerable<Person> GetPersonList();
    Person GetPersonById(int id);
    void CreatePerson(Person person);
    void UpdatePerson(Person person);
    void DeletePersonById(int id);
    
}
