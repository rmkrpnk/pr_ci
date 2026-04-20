using System;
using System.IO;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                RunCliAnalyzer(args[0]);
                return;
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string testFolder = Directory.GetCurrentDirectory();
            string testCacheFolder = Path.Combine(testFolder, "TestCache");

            if (!Directory.Exists(testCacheFolder))
            {
                Directory.CreateDirectory(testCacheFolder);
                File.WriteAllText(Path.Combine(testCacheFolder, "dummy.txt"), "Сміття");
            }

            Task1_FileAnalyzer.Execute();
            Task2_FolderInspector.Execute(testFolder);
            Task3_LargestFile.Execute(testFolder);

            Task4_CacheCleaner.Execute(testCacheFolder);

            Console.WriteLine("Усі завдання виконано!");
        }

        static void RunCliAnalyzer(string path)
        {
            Console.WriteLine($"File Analyzer CLI running for: {path}\n");

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Error: Directory not found.");
                return;
            }

            DirectoryInfo dir = new DirectoryInfo(path);

            try
            {
                FileInfo[] files = dir.GetFiles("*.*", SearchOption.AllDirectories);
                DirectoryInfo[] folders = dir.GetDirectories("*", SearchOption.AllDirectories);

                long totalSize = 0;
                FileInfo largest = null;

                foreach (FileInfo f in files)
                {
                    totalSize += f.Length;
                    if (largest == null || f.Length > largest.Length)
                    {
                        largest = f;
                    }
                }

                Console.WriteLine($"Folders: {folders.Length}");
                Console.WriteLine($"Files: {files.Length}");
                Console.WriteLine($"Total size: {totalSize / 1024 / 1024} MB");

                if (largest != null)
                {
                    Console.WriteLine($"Largest file: {largest.Name}");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: Access denied to some folders.");
            }
        }
    }
}