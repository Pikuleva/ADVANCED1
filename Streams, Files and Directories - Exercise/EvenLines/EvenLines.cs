namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string line;
            int count = 0;
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (count%2 == 0)
                    {
                        string replacedSymbols = ReplacedSymbols(line);
                        string reversed = ReversedText(replacedSymbols);
                        sb.AppendLine(reversed);
                    }
                    count++;
                }
            }
            return sb.ToString();
        }

        private static string ReplacedSymbols(string line)
        {
            
            
            StringBuilder sb = new StringBuilder(line);
            string[] symbols = { "-", ",",".", "!", "?" };
            foreach (var symbol in symbols)
            {
                sb.Replace(symbol, "@");
            }
            return sb.ToString();
        }

        private static string ReversedText(string replacedSymbols)
        {
            string[] reversed = replacedSymbols.Split(" ").Reverse().ToArray();
            return string.Join(" ", reversed);
        }
    }
}
