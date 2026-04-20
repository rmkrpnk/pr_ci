using System;
using System.IO;

namespace Practice3
{
    public class Task4_CacheCleaner
    {
        public static void Execute(string cachePath)
        {
            Console.WriteLine($"=== Завдання 4: Очищення кешу ({cachePath}) ===");

            if (!Directory.Exists(cachePath))
            {
                Console.WriteLine("Папка cache не знайдена. Будь ласка, створіть тестову папку.\n");
                return;
            }

            CleanWithRecursionWrapper(cachePath);
            Console.WriteLine();
        }

        private static void CleanWithoutRecursion(string path)
        {
            int deletedFilesCount = 0;
            long totalFreedSpace = 0;

            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                totalFreedSpace += fi.Length;

                File.Delete(file);
                deletedFilesCount++;
            }

            PrintReport(deletedFilesCount, totalFreedSpace);
        }

        private static void CleanWithRecursionWrapper(string path)
        {
            int deletedFilesCount = 0;
            long totalFreedSpace = 0;

            CleanRecursive(path, ref deletedFilesCount, ref totalFreedSpace);

            PrintReport(deletedFilesCount, totalFreedSpace);
        }

        private static void CleanRecursive(string path, ref int count, ref long space)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                FileInfo fi = new FileInfo(file);
                space += fi.Length;

                File.Delete(file);
                count++;
            }

            foreach (string dir in Directory.GetDirectories(path))
            {
                CleanRecursive(dir, ref count, ref space);
            }
        }

        private static void PrintReport(int count, long space)
        {
            Console.WriteLine("--- Звіт про очищення ---");
            Console.WriteLine($"Видалено файлів: {count}");
            Console.WriteLine($"Звільнено місця: {space / 1024.0 / 1024.0:F2} MB ({space} bytes)");
        }
    }
}