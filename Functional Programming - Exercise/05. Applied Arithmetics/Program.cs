using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Func<int, int> action;
            string input = Console.ReadLine();
            
            while (input != "end")
            {
                if (input == "add")
                {
                    foreach (var x in numbers)
                    {
                        action = x => x + 1;
                    }           
                }
                if (input == "multiply")
                {
                    foreach (var x in numbers)
                    {
                        action = x => x*2;
                    }
                }
                if (input == "subtract")
                {
                    foreach (var x in numbers)
                    {
                        action = x => x - 1;
                    }
                }
                if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }

                input = Console.ReadLine();
            }

        }
    }
}
