using System;
using System.Collections;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(children);

            int n = int.Parse(Console.ReadLine());
            int tosses = 1;

            while (queue.Count > 0)
            {
                if (queue.Count == 1)
                {
                    Console.WriteLine($"Last is {queue.Dequeue()}");
                    break;
                }
                string currChild = queue.Dequeue();
                if (tosses < n)
                {
                    queue.Enqueue(currChild);
                    tosses++;
                }
                else
                {
                    Console.WriteLine($"Removed {currChild}");
                    tosses = 1;
                }
                
            }
        }
    }
}
