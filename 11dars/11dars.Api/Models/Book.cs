namespace _11dars.Api.Models;

public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Description { get; set; }
    public int PageNumber { get; set; }
    public int Price { get; set; }
    public List<string> AuthorsName { get; set; } = new List<string>();
    public List<string> ReadersName { get; set; } = new List<string>();
}
