namespace rawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new(
                    input[0],
                    int.Parse(input[1]),
                    int.Parse(input[2]),
                    int.Parse(input[3]),
                    input[4],
                    double.Parse(input[5]),
                    int.Parse(input[6]),
                    double.Parse(input[7]),
                    int.Parse(input[8]),
                    double.Parse(input[9]),
                    int.Parse(input[10]),
                    double.Parse(input[11]),
                    int.Parse(input[12])
                    );
              cars.Add(car);
            }

            //string[] filter;
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                string[] filter = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .Select(c => c.Model).ToArray();
                foreach (var car in filter)
                {
                    Console.WriteLine(car);
                }
            }
            else if (command == "flammable")
            {
                string[] filter = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power>250)
                    .Select(c => c.Model).ToArray();
                foreach (var car in filter)
                {
                    Console.WriteLine(car);
                }
            }

            
        }
    }
}