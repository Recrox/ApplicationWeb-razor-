using Core.Models;

namespace Buisness.Concretes;

public interface IPizzaDomain
{
    IEnumerable<Pizza> GetPizzas();
    void Create(Pizza pizza);
    Pizza GetPizzaById(int? id);
    void DeleteById(int id);
    void Update(Pizza person);
}