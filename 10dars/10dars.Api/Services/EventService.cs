using _10dars.Api.Models;

namespace _10dars.Api.Services;

public class EventService
{
    private List<Event> events;

    public EventService()
    {
        events = new List<Event>();
        DataSeed();
    }

    public Event AddEvent(Event newEvent)
    {
        newEvent.Id = Guid.NewGuid();
        events.Add(newEvent);

        return newEvent;
    }

    public Event GetById(Guid id)
    {
        foreach (var eventDb in events)
        {
            if (eventDb.Id == id)
            {
                return eventDb;
            }
        }

        return null;
    }

    public bool DeleteEvent(Guid id)
    {
        var eventFtomDb = GetById(id);

        if (eventFtomDb is null)
        {
            return false;
        }

        events.Remove(eventFtomDb);
        return true;
    }

    public bool UpdateEvent(Event newEvent)
    {
        var eventFtomDb = GetById(newEvent.Id);

        if (eventFtomDb is null)
        {
            return false;
        }

        var index = events.IndexOf(eventFtomDb);
        events[index] = newEvent;
        return true;
    }

    public List<Event> GetAllEvents()
    {
        return events;
    }

    public List<Event> GetEventsByLocation(string location)
    {
        var eventsByLocation = new List<Event>();

        foreach (var eventDb in events)
        {
            if (eventDb.Location == location)
            {
                eventsByLocation.Add(eventDb);
            }
        }

        return eventsByLocation;
    }

    public Event GetPopularEvent()
    {
        var popularEvent = new Event();

        foreach(var eventDb in events)
        {
            if(popularEvent.Attendences.Count < eventDb.Attendences.Count)
            {
                popularEvent = eventDb;
            }
        }

        return popularEvent;
    }


    public Event GetMaxTaggedEvent()
    {
        var tagEvent = new Event();

        foreach (var eventDb in events)
        {
            if (tagEvent.Tags.Count < eventDb.Tags.Count)
            {
                tagEvent = eventDb;
            }
        }

        return tagEvent;
    }


    public bool AddPersonToEvent(Guid eventId, string personName)
    {
        var eventFromDb = GetById(eventId);

        if(eventFromDb is null)
        {
            return false;
        }

        eventFromDb.Attendences.Add(personName);
        return true;
    }

    public void DataSeed()
    {
        var eventToDb = new Event()
        {
            Id = Guid.NewGuid(),
            Description = "Voqiya tasirli",
            Title = "To'y",
            Location = "Chorsu",
            HappenedDate = DateTime.Now.AddDays(-5),
            Attendences = new List<string>()
            {
                "Sardor", "Abror", "Odina"
            },
            Tags = new List<string>()
            {
                "Ajoib", "Tasirli", "Shoxona"
            },
        };

        events.Add(eventToDb);
    }
}
