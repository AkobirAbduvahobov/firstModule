namespace _8dars.Models;

public class Restaurant
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Location { get; set; }

    public string Menu { get; set; }

    public int Capacity { get; set; }

    public DateTime OpenedDay { get; set; }
}

