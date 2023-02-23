using ApplicationWeb.Models;
using AutoMapper;
using Buisness.Concretes;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationWeb.Controllers;

public class PizzaController : Controller
{
    IPizzaDomain pizzaDomain;
    IMapper mapper;

    public PizzaController(IPizzaDomain pizzaDomain, IMapper mapper)
    {
        this.pizzaDomain = pizzaDomain;
        this.mapper = mapper;
    }

    public IActionResult Index()
    {
        return View(this.mapper.Map<IEnumerable<PizzaModel>>(this.pizzaDomain.GetPizzas()));
    }

    public IActionResult Edit(int? id)
    {
        if(!id.HasValue)
            return View();
        return View(this.mapper.Map<PizzaModel>(this.pizzaDomain.GetPizzaById(id)));
    }

    public IActionResult DeleteById(int id)
    {
        this.pizzaDomain.DeleteById(id);

        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult EditOrCreate(PizzaModel pizzaModel)
    {
        var personCore = this.mapper.Map<Pizza>(pizzaModel);
        if (personCore.Id > 0)
            this.pizzaDomain.Update(personCore);
        else
            this.pizzaDomain.Create(personCore);

        return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
        return View(this.mapper.Map<PizzaModel>(this.pizzaDomain.GetPizzaById(id)));
    }
}
