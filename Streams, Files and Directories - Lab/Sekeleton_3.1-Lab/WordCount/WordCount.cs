namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string[] words;
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                words = reader.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            using (StreamReader reader = new StreamReader(textFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {

                    string[] text = reader.ReadToEnd().Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    Dictionary<string, int> output = new Dictionary<string, int>();
                    for (int i = 0; i < words.Length; i++)
                    {
                        for (int k = 0; k < text.Length; k++)
                        {
                            if (text[k].ToLower() == words[i].ToLower())
                            {
                                if (output.ContainsKey(text[k].ToLower()))
                                {
                                    output[text[k].ToLower()]++;
                                }
                                else
                                {
                                    output.Add(text[k].ToLower(), 1);
                                }
                            }
                        }
                    }
                    foreach (KeyValuePair<string, int> word in output)
                    {
                        writer.WriteLine($"{word.Key} - {word.Value}");
                    }
                    
                }
            }
        }
    }
}
