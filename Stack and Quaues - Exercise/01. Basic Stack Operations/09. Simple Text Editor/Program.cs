using System;
using System.Collections;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> change = new Stack<string>();
            string text = string.Empty;
            change.Push(text);

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int command = int.Parse(input[0]);
                switch (command)
                {
                    case 1:
                        change.Push(text);

                        text += input[1];

                        break;
                    case 2:
                        change.Push(text);

                        int del = int.Parse(input[1]);
                        text =text.Remove(text.Length-del);
                        break;
                    case 3:
                        int index = int.Parse(input[1]);
                        Console.WriteLine(text[index-1]);
                        break;
                    case 4:
                        text = change.Pop();
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
