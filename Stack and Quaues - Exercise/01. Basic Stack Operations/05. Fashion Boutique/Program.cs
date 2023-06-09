using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> cloaths = new Stack<int>(input);
            int rack = 0;
            int capicity = int.Parse(Console.ReadLine());
            while (cloaths.Count > 0)
            {
                rack++;
                int currCap = capicity;
                while (currCap>0 && cloaths.Count>0)
                {
                    if (cloaths.Peek() <= currCap)
                    {
                        currCap -= cloaths.Pop();
                    }
                    else
                    {
                        currCap = 0;
                    }
                }
                
            }
            Console.WriteLine(rack);
        }
    }
}
