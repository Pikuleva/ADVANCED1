using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input = Console.ReadLine();

            while (input!="END")
            {
                string[] command = input.Split(", ");
                string action = command[0];
                string number = command[1];
                if (action == "IN")
                {
                    cars.Add(number);
                }
                else if (action == "OUT")
                {
                    cars.Remove(number);
                }
                input = Console.ReadLine();
            }
            if (cars.Count>0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
