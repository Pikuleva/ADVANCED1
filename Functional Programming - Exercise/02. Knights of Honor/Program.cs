using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string> names = n => Console.WriteLine($"Sir {n}");
            foreach (var name in input)
            {
                names(name);
            }
        }
    }
}
