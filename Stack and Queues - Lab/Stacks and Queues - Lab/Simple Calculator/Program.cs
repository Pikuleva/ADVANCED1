using System;
using System.Collections;
using System.Collections.Generic;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> number = new Stack<string>(input);
            Stack<string> numbers = new Stack<string>();
            int n = number.Count;
            for (int i = 0; i < n; i++)
            {
                string cur = number.Pop();
                numbers.Push(cur);
            }
            int firstNum = int.Parse(numbers.Pop());
            int sum = firstNum;
            while (numbers.Count>0)
            {
                
                string sign = numbers.Pop();
                if (sign == "-")
                {
                    int secondNum = int.Parse(numbers.Pop());
                    sum -= secondNum;
                    
                }
                else if (sign == "+")
                {
                    int secondNum = int.Parse(numbers.Pop());
                    sum += secondNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
