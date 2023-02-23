using ApplicationWeb.Models;
using AutoMapper;
using Core.Models;

namespace ApplicationWeb.Mappings;

public class ApiMapping : Profile
{
    public ApiMapping()
    {
        this.CreateMap<Person, PersonModel>().ReverseMap();
        this.CreateMap<Pizza, PizzaModel>().ReverseMap();
    }
}
