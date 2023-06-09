namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Predicate<string>> filters = new();
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] input = command.Split(";").ToArray();

                string action = input[0];
                string filter = input[1];
                string value = input[2];
                if (action == "Add filter")
                {
                    if (!filters.ContainsKey(filter+value))
                    {
                        filters.Add(filter + value, GetFilter(filter, value));

                    }
                }
                else
                {
                    if (filters.ContainsKey(filter+value))
                    {
                        filters.Remove(filter + value);
                    }
                }
            }
            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }
            Console.WriteLine(string.Join(" ", people));
        }
        static Predicate<string> GetFilter(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with":
                    return x => x.StartsWith(value);
                case "Ends with":
                    return x => x.EndsWith(value);
                case "Length":
                    return x => x.Length == int.Parse(value);
                case "Contains":
                    return x => x.Contains(value);
                default:
                    return default;
            }
        }
    }
}