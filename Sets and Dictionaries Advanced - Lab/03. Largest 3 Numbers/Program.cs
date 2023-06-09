using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> orderIn = input.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", orderIn));
            
        }
    }
}
