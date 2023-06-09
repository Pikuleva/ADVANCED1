namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Predicate<string> predicate = name => name.Length <= lenght;
            List<string> result = new();
            foreach (string name in names)
            {
                if (predicate(name))
                {
                    result.Add(name);
                }
            }
            foreach (string name in result)
            {
                Console.WriteLine($"{name} ");
            }
            
        }
    }
}