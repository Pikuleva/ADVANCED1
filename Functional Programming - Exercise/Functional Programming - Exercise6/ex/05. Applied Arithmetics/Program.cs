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
            string input = Console.ReadLine();

            Func<string, List<int>, List<int>> action = (input, numbers) =>
            {
                List<int> result = new List<int>();

               
                    if (input == "add")
                    {
                        foreach (var x in numbers)
                        {
                            result.Add(x + 1);
                        }
                    }
                    if (input == "multiply")
                    {
                        foreach (var x in numbers)
                        {
                            result.Add(x * 2);
                        }
                    }
                    if (input == "subtract")
                    {
                        foreach (var x in numbers)
                        {
                            result.Add(x - 1);
                        }
                    }
                    if (input == "print")
                    {
                        Console.WriteLine(string.Join(" ", result));
                    }

                
                return result;
            };

            Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));
            while (input != "end")
            {
                if (input == "print")
                {
                    print(numbers);
                }
                else
                {
                    numbers = action(input, numbers);
                }
                input = Console.ReadLine();
            }
         

        }
    }
}
