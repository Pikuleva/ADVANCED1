using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int howMany = input[0];
            int numForPop = input[1];
            int numToFind = input[2];
            Queue<int> nums = new Queue<int>();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < howMany; i++)
            {
                nums.Enqueue(numbers[i]);
            }
            for (int j = 0; j < numForPop; j++)
            {
                nums.Dequeue();
            }
            if (nums.Contains(numToFind))
            {
                Console.WriteLine("true");
            }
            else if (nums.Count == 0)
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
