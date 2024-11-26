using _10dars.Api.Models;
using _10dars.Api.Services;

namespace _10dars.Api;

public class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person()
        {
            Id = Guid.NewGuid(),
            FirstName = "wwww",
            LastName = "eeeee",
            Age = 1,
        };

        var person3 = person1;

        var person2 = new Person()
        {
            Id = person1.Id,
            FirstName = person1.FirstName,
            LastName = person1.LastName,
            Age = 1,
        };

        person2.FirstName = "salom";
        Console.WriteLine(person1.FirstName);

        if(person2 == person1) Console.WriteLine("Teng p1 == p2");
        if(person3 == person1) Console.WriteLine("Teng p1 == p3");
        
       
    }
}
