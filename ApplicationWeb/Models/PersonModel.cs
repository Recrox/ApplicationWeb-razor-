namespace ApplicationWeb.Models;

public class PersonModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool IsAlive { get; set; }

    /*public PersonModel(int id, string firstName, string lastName, int age, bool isAlive)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        IsAlive = isAlive;
    }*/
}
