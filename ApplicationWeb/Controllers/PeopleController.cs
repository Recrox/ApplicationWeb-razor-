using ApplicationWeb.Models;
using AutoMapper;
using Buisness.Concretes;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationWeb.Controllers;

public class PeopleController : Controller //fais le lien directement avec le dossier dans views : "People"
{
    private IPersonDomain personDomain;
    private IMapper mapper;


    public PeopleController(IPersonDomain personDomain,IMapper mapper)
    {
        this.personDomain = personDomain;
        this.mapper = mapper;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(this.mapper.Map<IEnumerable<PersonModel>>(this.personDomain.GetPersonList()));
    }

    public IActionResult Edit(int? id)
    {
        if (!id.HasValue)
            return View();

        return View(this.mapper.Map<PersonModel>(this.personDomain.GetPersonById(id.Value)));

    }

    [HttpPost]
    public IActionResult EditOrCreate(PersonModel personModel)
    {
        var newPerson = this.mapper.Map<Person>(personModel);
            
        if (newPerson.Id>0)
        {
            this.personDomain.UpdatePerson(newPerson);
        }
        else
        {
            this.personDomain.CreatePerson(newPerson);
        }

        return RedirectToAction("Index"); 
    }

    public IActionResult DeleteById(int id)
    {
        this.personDomain.DeletePersonById(id);
        return this.RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
        return View(this.mapper.Map<PersonModel>(this.personDomain.GetPersonById(id)));
    }
}
