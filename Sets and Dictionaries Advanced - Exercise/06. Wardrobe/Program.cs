using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] cloathsIn = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }
                for (int k   = 0; k < cloathsIn.Length; k++)
                {
                    if (!clothes[color].ContainsKey(cloathsIn[k]))
                    {
                        clothes[color].Add(cloathsIn[k], 0);
                    }
                    clothes[color][cloathsIn[k]]++; 
                }
               
            }
            string[] search = Console.ReadLine().Split();

            foreach (KeyValuePair<string, Dictionary<string, int>> color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (KeyValuePair<string, int> cloath in color.Value)
                {

                  
                    if (search[0] == color.Key && search[1] == cloath.Key)
                    {
                        Console.WriteLine($"* {cloath.Key} - {cloath.Value} (found!)");

                    }
                    else
                    {
                        Console.WriteLine($"* {cloath.Key} - {cloath.Value}");

                    }
                }
            }

        }
    }
}
