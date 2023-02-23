using Microsoft.EntityFrameworkCore;
using Providers.Sql.Models;

namespace Providers.Sql;

public class WebAppPeopleContext : DbContext
{
    public WebAppPeopleContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Person> Person { get; set; }
    public DbSet<Pizza> Pizza { get; set; }
}
