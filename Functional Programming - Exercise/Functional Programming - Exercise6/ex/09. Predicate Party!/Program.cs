namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string action = input[0];
                string filter = input[1];
                string value = input[2];

                if (action == "Remove")
                {
                    names.RemoveAll(GetFilter(filter, value));
                }
                else
                {
                    List<string> find = names.FindAll(GetFilter(filter, value));
                    foreach (var person in find)
                    {
                        int index = names.FindIndex(x => x == person);
                        names.Insert(index, person);
                    }
                }
            }
            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static Predicate<string> GetFilter(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith":
                    return x=>x.StartsWith(value);
                case "EndsWith":
                    return x=>x.EndsWith(value);
                case "Length":
                    return x=>x.Length == int.Parse(value);
                default:
                    return  default;
            }
        }
    }
}