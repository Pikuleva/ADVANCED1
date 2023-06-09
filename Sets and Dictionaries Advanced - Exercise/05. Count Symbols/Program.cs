using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            char[] input = Console.ReadLine().ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];
                if (!letters.ContainsKey(curr))
                {
                    letters.Add(curr, 0);
                }
                letters[curr]++;
            }
            foreach (KeyValuePair<char, int> letter in letters.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
