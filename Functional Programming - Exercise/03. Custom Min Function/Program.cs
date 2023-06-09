using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();


            Func<HashSet<int>, int> min = numbers =>
            {
                int minNum = int.MaxValue;

                foreach (var num in numbers)
                {
                    if (num < minNum)
                    {
                        minNum = num;
                    }
                }

                return minNum;
            };
            Console.WriteLine(min(numbers));
        }
    }
}
