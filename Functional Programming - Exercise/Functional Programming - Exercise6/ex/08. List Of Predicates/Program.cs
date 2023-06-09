using System.Net.WebSockets;
using System.Text;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Predicate<int>> result = new();

            int end = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] numbers = Enumerable.Range(1, end).ToArray();

            foreach (var divide in dividers)
            {
                result.Add(x => x % divide == 0);
            }
            foreach (var number in numbers)
            {
                bool isDivisible = true;
                foreach (var match in result)
                {
                    if (!match(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}