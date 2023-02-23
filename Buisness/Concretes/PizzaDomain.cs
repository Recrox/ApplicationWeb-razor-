
using Core.Models;
using Data;

namespace Buisness.Concretes;

public class PizzaDomain : IPizzaDomain
{
    IPizzaRepository pizzaRepository;

    public PizzaDomain(IPizzaRepository pizzaRepository)
    {
        this.pizzaRepository = pizzaRepository;
    }

    public void Create(Pizza pizza) => this.pizzaRepository.Create(pizza);

    public void DeleteById(int id)
    {
        this.pizzaRepository.DeleteById(id);
    }

    public Pizza GetPizzaById(int? id)
    {
        return this.pizzaRepository.GetPizzaById(id);
    }

    public IEnumerable<Pizza> GetPizzas() => this.pizzaRepository.GetPizzas();

    public void Update(Pizza person)
    {
        this.pizzaRepository.Update(person);
    }
}
