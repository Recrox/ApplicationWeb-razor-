

using AutoMapper;
using Core.Models;
using Data;

namespace Providers.Sql.Repositories;

public class PizzaRepository : IPizzaRepository
{
    WebAppPeopleContext Context;
    IMapper mapper;

    public PizzaRepository(WebAppPeopleContext context, IMapper mapper)
    {
        Context = context;
        this.mapper = mapper;
    }

    public void Create(Pizza pizza)
    {
        this.Context.Add(this.mapper.Map<Pizza, Models.Pizza>(pizza));
        this.Context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        var pizza = this.Context.Pizza.Find(id);
        if(pizza != null)
        {
            this.Context.Pizza.Remove(pizza);
            this.Context.SaveChanges();
        }
    }

    public Pizza GetPizzaById(int? id)
    {
        return this.mapper.Map<Pizza>(this.Context.Pizza.Find(id));
    }

    public IEnumerable<Pizza> GetPizzas()
    {
        return this.mapper.Map<IEnumerable<Pizza>>(this.Context.Pizza);
    }

    public void Update(Pizza person)
    {
        this.Context.Update(this.mapper.Map<Models.Pizza>(person));
        this.Context.SaveChanges();
    }
}
