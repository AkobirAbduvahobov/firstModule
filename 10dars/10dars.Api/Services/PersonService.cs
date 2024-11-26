using _10dars.Api.Models;

namespace _10dars.Api.Services;

public class PersonService
{
    private List<Person> persons;

    public PersonService()
    {
        persons = new List<Person>();
        DataSeed();
    }

    public Person AddPerson(Person person)
    {
        person.Id = Guid.NewGuid();
        persons.Add(person);

        return person;
    }

    public Person GetById(Guid id)
    {
        foreach (var person in persons)
        {
            if (person.Id == id)
            {
                return person;
            }
        }

        return null;
    }

    public bool DeletePerson(Guid id)
    {
        var personFromDb = GetById(id);
        if (personFromDb is null)
        {
            return false;
        }

        persons.Remove(personFromDb);
        return true;
    }

    public bool UpdatePerson(Person person)
    {
        var personFromDb = GetById(person.Id);
        if (personFromDb is null)
        {
            return false;
        }

        var index = persons.IndexOf(person);
        persons[index] = person;
        return true;
    }

    public List<Person> GetPersons()
    {
        return persons;
    }

    public bool ConnecToPassport(Guid personId, Guid passportId)
    {
        var personFromDb = GetById(personId);

        if(personFromDb is null)
        {
            return false;
        }

        var index = persons.IndexOf(personFromDb);
        persons[index].PassportId = passportId; 
        return true;
    }

    public void DataSeed()
    {
        persons.Add(new Person()
        {
            Id = Guid.NewGuid(),
            FirstName = "Lobar",
            LastName = "Ketmonova",
            Age = 18,
        });
    }
}

