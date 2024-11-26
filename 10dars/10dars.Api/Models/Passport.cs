namespace _10dars.Api.Models;

public class Passport
{
    public Guid Id { get; set; }

    public string Serie { get; set; }

    public string Country { get; set; }

    public DateTime GivenDate { get; set; }

    public Guid PersonId { get; set; }
}
