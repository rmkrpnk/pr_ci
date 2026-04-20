using System;
using System.IO;

namespace Practice3
{
    public class Task3_LargestFile
    {
        public static void Execute(string targetPath)
        {
            Console.WriteLine($"=== Завдання 3: Пошук найбільшого файлу ({targetPath}) ===");

            if (!Directory.Exists(targetPath))
            {
                Console.WriteLine("Вказана папка не існує!\n");
                return;
            }

            DirectoryInfo dirInfo = new DirectoryInfo(targetPath);
            FileInfo largestFile = null;

            try
            {
                FileInfo[] allFiles = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);

                foreach (FileInfo file in allFiles)
                {
                    if (largestFile == null || file.Length > largestFile.Length)
                    {
                        largestFile = file;
                    }
                }

                if (largestFile != null)
                {
                    Console.WriteLine($"Name: {largestFile.Name}");
                    Console.WriteLine($"Size: {largestFile.Length / 1024.0 / 1024.0:F2} MB ({largestFile.Length} bytes)");
                    Console.WriteLine($"Path: {largestFile.FullName}");
                }
                else
                {
                    Console.WriteLine("У цій папці немає файлів.");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Помилка: Немає доступу до деяких системних папок.");
            }

            Console.WriteLine();
        }
    }
}