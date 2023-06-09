using System.Reflection;

namespace speedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            Car car = new();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);
                car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(car);
            }
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                
                string[] action = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = action[1];
                double distance = double.Parse(action[2]);

                Car carForDriving = cars
                      .Where(x => x.Model == carModel)
                      .ToList()
                      .First();

                carForDriving.DistaceTraveled(carModel, distance);
                


            }

            
            foreach (var ca in cars)
            {
                Console.WriteLine($"{ca.Model} {ca.FuelAmount:f2} {ca.TravelledDistance:f0}");
            }
        }
    }
}