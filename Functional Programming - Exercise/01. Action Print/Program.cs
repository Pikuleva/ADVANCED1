using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string> names = n => Console.WriteLine(n);
            foreach (var name in input)
            {
                names(name);
            }
        }
    }
}
