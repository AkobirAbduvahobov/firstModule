using _8dars.Models;
using _8dars.Services;

namespace _8dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFrontEnd();
        }

        public static void RunFrontEnd()
        {
            var restaurantService = new RestaurantService();


            while (true)
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Upddate");
                Console.WriteLine("4. GetAll");
                Console.WriteLine("5. GetById");
                Console.Write("Enter : ");
                var option = Console.ReadLine();

                if (option == "1")
                {
                    var restaurant = new Restaurant();
                    Console.Write("Enter name : ");
                    restaurant.Name = Console.ReadLine();
                    Console.Write("Enter description : ");
                    restaurant.Description = Console.ReadLine();
                    Console.Write("Enter location : ");
                    restaurant.Location = Console.ReadLine();
                    Console.Write("Enter capacity : ");
                    restaurant.Capacity = int.Parse(Console.ReadLine());
                    Console.Write("Enter menu : ");
                    restaurant.Menu = Console.ReadLine();
                    restaurant.OpenedDay = DateTime.Now;

                    restaurantService.AddRestaurant(restaurant);
                }

                else if (option == "2")
                {
                    Console.Write("Enter id to delete : ");
                    var id = Guid.Parse(Console.ReadLine());
                    var resFromFunc = restaurantService.DeleteRestaurant(id);
                    Console.WriteLine(resFromFunc);
                }

                else if (option == "3")
                {
                    var restaurant = new Restaurant();
                    Console.Write("Enter id to update : ");
                    restaurant.Id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter name : ");
                    restaurant.Name = Console.ReadLine();
                    Console.Write("Enter description : ");
                    restaurant.Description = Console.ReadLine();
                    Console.Write("Enter location : ");
                    restaurant.Location = Console.ReadLine();
                    Console.Write("Enter capacity : ");
                    restaurant.Capacity = int.Parse(Console.ReadLine());
                    Console.Write("Enter menu : ");
                    restaurant.Menu = Console.ReadLine();
                    Console.Write("Enter date time : ");
                    restaurant.OpenedDay = DateTime.Parse(Console.ReadLine());

                    restaurantService.UpdateRestaurant(restaurant);
                }

                else if (option == "4")
                {
                    var restaurants = restaurantService.GetAllRestaurants();

                    foreach (var restaurant in restaurants)
                    {
                        string info = $"Id : {restaurant.Id}, Name : {restaurant.Name}, Description : {restaurant.Description}"
                            + $" Menu : {restaurant.Menu}, Capacity : {restaurant.Capacity}, Location : {restaurant.Location}"
                            + $" Opened day : {restaurant.OpenedDay}";
                        Console.WriteLine($"{info}");
                    }
                }

                else if (option == "5")
                {
                    Console.Write("Enter id to get : ");
                    var id = Guid.Parse(Console.ReadLine());

                    var restaurant = restaurantService.GetById(id);
                    string info = $"Id : {restaurant.Id}, Name : {restaurant.Name}, Description : {restaurant.Description}"
                            + $" Menu : {restaurant.Menu}, Capacity : {restaurant.Capacity}, Location : {restaurant.Location}"
                            + $" Opened day : {restaurant.OpenedDay}";

                    Console.WriteLine(info);
                }

                Console.ReadKey();
                Console.Clear();
            }

        }


    }
}
