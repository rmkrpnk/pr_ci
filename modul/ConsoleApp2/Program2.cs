using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string groupNumber = "pd24";
            string logFileName = $"log{groupNumber}.txt";

            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger(logFileName);

            publisher.MessageSent += logger.OnMessageSent;

            Console.WriteLine("Треба ввести текст у консоль 4 рази.\n");

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Введення {i}/4: ");
                string input = Console.ReadLine()!;
                publisher.Send(input);
            }

            publisher.MessageSent -= logger.OnMessageSent;

            Console.WriteLine($"\nВведення завершено. Відкрийте файл {logFileName}.");
        }
    }
}