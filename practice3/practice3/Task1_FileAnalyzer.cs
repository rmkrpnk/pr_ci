using System;
using System.IO;

namespace Practice3
{
    public class Task1_FileAnalyzer
    {
        public static void Execute()
        {
            Console.WriteLine("=== Завдання 1: Аналізатор текстового файлу ===");

            string inputFile = "story.txt";
            string outputFile = "report.txt";

            if (!File.Exists(inputFile))
            {
                File.WriteAllText(inputFile, "Це перша лінія тексту.\nА це друга лінія, тут більше слів.\nКінець казки.");
                Console.WriteLine($"[Info] Файл {inputFile} створено для тестування.");
            }

            int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;

            using (StreamReader reader = new StreamReader(inputFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;
                    charCount += line.Length;

                    string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine("--- Статистика тексту ---");
                writer.WriteLine($"Кількість рядків: {lineCount}");
                writer.WriteLine($"Кількість слів: {wordCount}");
                writer.WriteLine($"Кількість символів: {charCount}");
            }

            Console.WriteLine($"Аналіз завершено. Результати записано у файл {outputFile}\n");
        }
    }
}