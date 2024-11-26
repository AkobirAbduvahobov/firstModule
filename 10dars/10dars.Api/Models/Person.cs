namespace _10dars.Api.Models;

public class Person
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public Guid PassportId { get; set; }

    public List<Guid> CarsId { get; set; }
}
