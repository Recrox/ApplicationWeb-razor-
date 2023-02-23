using Core.Models;

namespace Data;

public interface IPizzaRepository
{
    IEnumerable<Pizza> GetPizzas();
    void Create(Pizza pizza);
    Pizza GetPizzaById(int? id);
    void DeleteById(int id);
    void Update(Pizza person);
}