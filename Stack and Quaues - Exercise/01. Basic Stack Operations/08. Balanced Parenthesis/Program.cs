using System;
using System.Collections;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> par = new Stack<string>();

           

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length % 2 != 0)
                {
                    Console.WriteLine("NO");
                    break;
                }
                if (input[i].ToString() == "{" || input[i].ToString() == "[" || input[i].ToString() == "(")
                {
                    par.Push(input[i].ToString());
                }
                else if (input[i].ToString() == "}" || input[i].ToString() == "]" || input[i].ToString() == ")" && par.Count>0)
                {
                    if (par.Peek() == "{" && input[i].ToString()=="}" && par.Count >0)
                    {
                        par.Pop();
                    }
                    else if (par.Peek() == "[" && input[i].ToString() == "]" && par.Count > 0)
                    {
                        par.Pop();
                    }
                    else if (par.Peek() == "(" && input[i].ToString() == ")" && par.Count > 0)
                    {
                        par.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                }
            }
            if (par.Count == 0 && input.Length%2 == 0)
            {
                Console.WriteLine("YES");
            }
           
        }
    }
}
