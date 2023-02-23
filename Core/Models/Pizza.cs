namespace Core.Models;

public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Calories { get; set; }
    public bool GrandFormat { get; set; }
}
