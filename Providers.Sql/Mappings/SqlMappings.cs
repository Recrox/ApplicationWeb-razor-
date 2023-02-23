using AutoMapper;
using Core.Models;

namespace Providers.Sql.Mappings;

public class SqlMappings : Profile
{
    public SqlMappings()
    {
        this.CreateMap<Person, Models.Person>().ReverseMap();
        this.CreateMap<Pizza, Models.Pizza>().ReverseMap();
    }
}
