using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresion = Console.ReadLine();

            Stack<int> find = new Stack<int>();

            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i] == '(')
                {
                    find.Push(i);
                }
                if (expresion[i] == ')')
                {
                    int open = find.Pop();
                    for (int j = open; j <= i; j++)
                    {
                        Console.Write(expresion[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
