namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "BMW",
                Model = "X6",
                Year = 2005

            };

            Console.WriteLine($"Make: {car.Make}\nmodel: {car.Model}\nyyear: {car.Year}");
        }
    
    }
}