using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> order = new Queue<int>(orders);
            Console.WriteLine(order.Max());

            while (true)
            {
                if (food-order.Peek() >= 0 && order.Count>0)
                {
                    food -= order.Dequeue();
                    if (order.Count == 0)
                    {
                        Console.WriteLine("Orders complete");
                        break;
                    }
                }
                if(food-order.Peek() <0 && order.Count>0)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", order)}");
                    break;
                }
            }
        }
    }
}
