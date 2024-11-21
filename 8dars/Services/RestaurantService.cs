using _8dars.Models;
using System.Linq;

namespace _8dars.Services;

public class RestaurantService
{
    private List<Restaurant> restaurants;
    public RestaurantService()
    {
        restaurants = new List<Restaurant>();
        DataSeed();
    }

    public Restaurant AddRestaurant(Restaurant restaurant)
    {
        restaurant.Id = Guid.NewGuid();
        restaurants.Add(restaurant);
        return restaurant;
    }

    public bool DeleteRestaurant(Guid restaurantId)
    {
        var exists = false;
        foreach(var restaurant in restaurants)
        {
            if(restaurant.Id == restaurantId)
            {
                restaurants.Remove(restaurant);
                exists = true;
                break;
            }
        }

        return exists;
    }

    public bool UpdateRestaurant(Restaurant updatedRestaurant)
    {
        for (var i = 0; i < restaurants.Count; i++)
        {
            if (restaurants[i].Id == updatedRestaurant.Id)
            {
                restaurants[i] = updatedRestaurant;
                return true;
            }
        }

        return false;
    }

    public Restaurant GetById(Guid restaurantId)
    {
        foreach (var restaurant in restaurants)
        {
            if (restaurant.Id == restaurantId)
            {
                return restaurant;
            }
        }

        return null;
    }

    public List<Restaurant> GetAllRestaurants()
    {
        return restaurants;
    }

    private void DataSeed()
    {
        var restaurant1 = new Restaurant()
        {
            Id = Guid.NewGuid(),
            Name = "Lola",
            Capacity = 100,
            Location = "Chorsu",
            Menu = "Dengiz",
            Description = "Qichchu joy",
            OpenedDay = DateTime.Now,
        };

        var restaurant2 = new Restaurant()
        {
            Id = Guid.NewGuid(),
            Name = "Baxt",
            Capacity = 100,
            Location = "Chorsu",
            Menu = "Hamma narsa",
            Description = "yaxshi joy",
            OpenedDay = DateTime.Now,
        };

        var restaurant3 = new Restaurant()
        {
            Id = Guid.NewGuid(),
            Name = "Bistro",
            Capacity = 50,
            Location = "Chorsu",
            Menu = "Go'shtli",
            Description = "tak sebe joy",
            OpenedDay = DateTime.Now,
        };

        restaurants.Add(restaurant1);
        restaurants.Add(restaurant2);
        restaurants.Add(restaurant3);
    }
}
