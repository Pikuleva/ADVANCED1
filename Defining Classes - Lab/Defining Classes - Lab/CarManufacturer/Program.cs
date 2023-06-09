namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            List<Tire> tires = new List<Tire>();

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tir = input.Split();
                tires.Add(Tire(int.Parse(tir[0]), double.Parse(tir[1])));
                
            }
        }
    }
}