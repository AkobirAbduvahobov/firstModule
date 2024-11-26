namespace _10dars.Api.Models;

public class Event
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Location { get; set; }

    public DateTime HappenedDate { get; set; }

    public List<string> Attendences { get; set; } 

    public List<string> Tags { get; set; } 
}
