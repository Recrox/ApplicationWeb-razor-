using ApplicationWeb.Mappings;
using Buisness.Concretes;
using Data;
using Microsoft.EntityFrameworkCore;
using Providers.Sql;
using Providers.Sql.Mappings;
using Providers.Sql.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(SqlMappings), typeof(ApiMapping)); //ajouter de mes mappeurs
builder.Services.AddTransient<IPersonRepository, PersonRepository>();//injection de dépendance
builder.Services.AddTransient<IPersonDomain, PersonDomain>();//injection de dépendance

builder.Services.AddTransient<IPizzaRepository, PizzaRepository>();
builder.Services.AddTransient<IPizzaDomain, PizzaDomain>();



builder.Services.AddDbContext<WebAppPeopleContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
  
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
