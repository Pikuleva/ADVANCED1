using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            Func<List<int>, Predicate<int>, List<int>> devisible = (numbers, match) =>
            {
                List<int> result = new();
                foreach (int num in numbers) 
                {
                    if (match(num))
                    {
                        result.Add(num);
                    }
                }  
                return result;
            };

            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> result = new();
               
                for (int i = numbers.Count-1; i >=0; i--) 
                {
                    result.Add(numbers[i]);
                }
                return result;
            };
            numbers = devisible(numbers, x => x % n != 0);
            numbers = reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}