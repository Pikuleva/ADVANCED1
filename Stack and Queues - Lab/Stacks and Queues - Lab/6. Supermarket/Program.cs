﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> customers = new Queue<string>();

            while (input != "End")
            {
                if (input != "Paid")
                {
                    customers.Enqueue(input);
                }
                else
                {
                    while(customers.Count>0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
