namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader readerInput1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader readerInput2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter output = new StreamWriter(outputFilePath))
                    {
                        while (!readerInput1.EndOfStream || !readerInput2.EndOfStream)
                        {
                            if (!readerInput1.EndOfStream)
                            {
                                output.WriteLine(readerInput1.ReadLine());

                            }
                            if (!readerInput2.EndOfStream)
                            {
                                output.WriteLine(readerInput2.ReadLine());

                            }
                        }
                    }

                }

            }
        }
    }
}
