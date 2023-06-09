using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstGroup = new HashSet<int>();
            HashSet<int> secondGroup = new HashSet<int>();
            HashSet<int> output = new HashSet<int>();

            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            for (int i = 0; i <  n; i++)
            {
                firstGroup.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                secondGroup.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var numFirst in firstGroup)
            {
                foreach (var numSecond in secondGroup)
                {
                    if (numFirst == numSecond)
                    {
                        output.Add(numSecond);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
