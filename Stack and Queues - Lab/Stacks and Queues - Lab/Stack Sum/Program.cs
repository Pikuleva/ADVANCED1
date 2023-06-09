using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] nums = numbers.Split().Select(int.Parse).ToArray();
            Stack<int> number = new Stack<int>(nums);
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split();
                string action = commands[0].ToLower();
                if (action == "add")
                {
                    number.Push(int.Parse(commands[1]));
                    number.Push(int.Parse(commands[2]));
                    
                }
                else if(action == "remove")
                {
                    int n = int.Parse(commands[1]);
                    if (number.Count >n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            number.Pop();
                        }
                        
                    }
                }

                input = Console.ReadLine();
            }
            int sum = number.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
