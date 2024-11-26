using _10dars.Api.Models;

namespace _10dars.Api.Services;

public class CarService
{
    private List<Car> cars;

    public CarService()
    {
        cars = new List<Car>();
    }

    public Car AddCar(Car car)
    {
        car.Id = Guid.NewGuid();
        cars.Add(car);

        return car;
    }

    public Car GetById(Guid id)
    {
        foreach (var car in cars)
        {
            if (car.Id == id)
            {
                return car;
            }
        }

        return null;
    }

    public bool DeleteCar(Guid id)
    {
        var carFromDb = GetById(id);
        if (carFromDb is null)
        {
            return false;
        }

        cars.Remove(carFromDb);
        return true;
    }

    public bool UpdateCar(Car car)
    {
        var carFromDb = GetById(car.Id);
        if (carFromDb is null)
        {
            return false;
        }

        var index = cars.IndexOf(car);
        cars[index] = car;  
        return true;
    }

    public List<Car> GetCars()
    {
        return cars;
    }
}
