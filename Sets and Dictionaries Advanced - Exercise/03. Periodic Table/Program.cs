using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();

            string[] input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                foreach (var el in input)
                {
                    elements.Add(el);
                }
            }
            foreach (var el in elements.OrderBy(x=>x))
            {
                Console.Write($"{el} ");
            }
        }
    }
}
