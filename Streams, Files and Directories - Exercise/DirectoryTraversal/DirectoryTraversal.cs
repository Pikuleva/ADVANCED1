namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> names = new SortedDictionary<string, List<FileInfo>>();
            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (!names.ContainsKey(fileInfo.Extension))
                {
                    names.Add(fileInfo.Extension, new List<FileInfo>());
                }
                names[fileInfo.Extension].Add(fileInfo);
            }
            StringBuilder sb = new StringBuilder();

            foreach (var name in names.OrderByDescending(x=>x.Value.Count))
            {
                sb.AppendLine(name.Key);

                foreach (var file in name.Value.OrderBy(x=>x.Length))
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length / 1024:f3}kb");
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + reportFileName;

            File.WriteAllText(filePath, textContent);
        }
    }
}
