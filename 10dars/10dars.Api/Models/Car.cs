namespace _10dars.Api.Models;

public class Car
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Model { get; set; }

    public string Color { get; set; }

    public double Price { get; set; }

    public Guid PersonId { get; set; }
}
