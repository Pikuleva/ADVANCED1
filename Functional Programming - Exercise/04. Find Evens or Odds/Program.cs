using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            int[] startEnd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string action = Console.ReadLine();
            Func<int, int, List<int>> generateList = (start, end) =>
            {
                List<int> range = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    range.Add(i);
                }
                return range;

            };
            List<int> numbers = new List<int>();
            if (startEnd[0]<=startEnd[1])
            {
                numbers = generateList(startEnd[0], startEnd[1]);

            }
            if (startEnd[0] > startEnd[1])
            {
                numbers = generateList(startEnd[1], startEnd[0]);

            }
            Predicate<int> match = number => number % 2 == 1;
            if (action == "odd")
            {
                match = number => number % 2 != 0;
            }
            else if(action == "even")
            {
                match = number => number % 2 == 0;
            }

            foreach (var number in numbers)
            {
                if (match(number))
                {
                    Console.Write($"{number} ");
                }
            }
            
            
        }
    }
}
