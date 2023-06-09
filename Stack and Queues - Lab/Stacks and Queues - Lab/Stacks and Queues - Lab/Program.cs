using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inChar = input.ToArray();
            Stack<char> output = new Stack<char>(inChar);
            for (int i = output.Count; i > 0; i--)
            {
                Console.Write(output.Pop());
            }
        }
    }
}
