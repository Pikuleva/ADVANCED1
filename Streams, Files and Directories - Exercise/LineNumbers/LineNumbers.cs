namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            int letter = 0;
            int symbol = 0;
            int lineCount = 0;
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        letter = 0;
                        symbol = 0;
                        lineCount++;
                        line = reader.ReadLine();
                        for (int i = 0; i < line.Length; i++)
                        {

                            if (Char.IsLetter(line[i]))
                            {
                                letter++;
                            }
                            else if (line[i] == '-' || line[i] == '!' || line[i] == ',' || line[i] == '.' || line[i] == '?' || line[i] == '\'')
                            {
                                symbol++;
                            }
                        }
                        writer.WriteLine($"Line {lineCount}: {line} ({letter})({symbol})");

                    }
                }

            }
        }
    }
}
