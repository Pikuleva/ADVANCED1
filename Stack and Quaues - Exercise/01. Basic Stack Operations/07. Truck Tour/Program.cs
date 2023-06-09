using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> petrol = new Queue<int>();
            int count = 0;
          
            
                for (int i = 0; i < n; i++)
                {
                    int[] station = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    petrol.Enqueue(station[0]);
                    petrol.Enqueue(station[1]);
                }
            int curFuel = petrol.Dequeue();
            int km = petrol.Dequeue();
            if (curFuel-km<0)
            {
                Console.WriteLine(curFuel);
                return;
            }
            while (petrol.Count > 0)
            {
                

                if (curFuel - km == n)
                {
                    Console.WriteLine(curFuel);
                    break;
                }
                else
                {
                    count++;
                }
                curFuel = petrol.Dequeue();
                km = petrol.Dequeue();
            }

            if (count == n-1)
            {
                Console.WriteLine(0);
            }
            
        }
    }
}
