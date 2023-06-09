using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack_and_Quaues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int howMany = input[0];
            int numForPop = input[1];
            int numToFind = input[2];
            Stack<int> nums = new Stack<int>();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < howMany; i++)
            {
                nums.Push(numbers[i]);
            }
            for (int j = 0; j < numForPop; j++)
            {
                nums.Pop();
            }
            if (nums.Contains(numToFind))
            {
                Console.WriteLine("true");
            }
            else if(nums.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(nums.Min());
            }
        }
    }
}
