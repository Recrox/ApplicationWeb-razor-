namespace ApplicationWeb.Models;

public class PizzaModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Calories { get; set; }
    public bool GrandFormat { get; set; }
}
