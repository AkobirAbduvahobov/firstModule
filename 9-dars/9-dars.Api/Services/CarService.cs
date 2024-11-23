using _9_dars.Api.Models;

namespace _9_dars.Api.Services;

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

    public Car GetCarById(Guid carId)
    {
        foreach (var car in cars)
        {
            if(car.Id == carId)
            {
                return car; 
            }
        }

        return null;
    }

    public bool DeleteCar(Guid carId)
    {
        var carFromDb = GetCarById(carId); 
        
        if(carFromDb is null)
        {
            return false;
        }

        cars.Remove(carFromDb);
        return true;
    }

    public bool UpdateCar(Car updatingCar)
    {
        var carFromDb = GetCarById(updatingCar.Id);

        if (carFromDb is null)
        {
            return false;
        }

        var index = cars.IndexOf(carFromDb);
        cars[index] = updatingCar;  

        return true;
    }

    public List<Car> GetAllCars()
    {
        return cars;
    }

    public List<Car> GetCarsByModel(string model)
    {
        var sameModelCars = new List<Car>();    

        foreach (var car in cars)
        {
            if(car.Model == model)
            {
                sameModelCars.Add(car);
            }
        }

        return sameModelCars;
    }

    public List<Car> GetAffordableCarsByPrice(double minPrice,  double maxPrice)
    {
        var responseCars = new List<Car>();

        foreach(var car in cars)
        {
            if(minPrice <= car.Price && car.Price <= maxPrice)
            {
                responseCars.Add(car);
            }
        }

        return responseCars;
    }
}
