using System;

namespace practice2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Task1_Runner.Execute();

            Console.WriteLine("\nНатисніть Enter для переходу до наступного завдання...\n");
            Console.ReadLine();

            Task2_Runner.Execute();

            Console.WriteLine("Всі практичні завдання виконано успішно! Натисніть Enter для виходу.");
            Console.ReadLine();
        }
    }
}