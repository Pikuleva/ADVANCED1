using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = s => s[0] == char.ToUpper(s[0]);

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(s => isUpper(s))
                .ToArray();

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
