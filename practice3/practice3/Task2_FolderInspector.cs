using System;
using System.IO;

namespace Practice3
{
    public class Task2_FolderInspector
    {
        public static void Execute(string targetPath)
        {
            Console.WriteLine($"=== Завдання 2: Інспектор папки ({targetPath}) ===");

            if (!Directory.Exists(targetPath))
            {
                Console.WriteLine("Вказана папка не існує!\n");
                return;
            }

            DirectoryInfo dirInfo = new DirectoryInfo(targetPath);

            Console.WriteLine("--- Підпапки ---");
            DirectoryInfo[] subDirs = dirInfo.GetDirectories();
            foreach (DirectoryInfo subDir in subDirs)
            {
                Console.WriteLine($"- {subDir.Name}");
            }

            Console.WriteLine("\n--- Файли ---");
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine($"Файл: {file.Name}");
                Console.WriteLine($"  Розмір: {file.Length} байт");
                Console.WriteLine($"  Створено: {file.CreationTime}");
            }
            Console.WriteLine();
        }
    }
}