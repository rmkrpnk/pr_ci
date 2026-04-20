using System;

namespace practice1
{
    public class Task3_Filtering
    {
        public delegate bool FilterPredicate(int number);

        public static void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (int num in numbers)
            {
                if (predicate(num))
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsGreaterThanFive(int number)
        {
            return number > 5;
        }

        public static void Execute()
        {
            Console.WriteLine("=== Завдання 3: Фільтрація списку ===");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Пошук парних чисел: ");
            FilterArray(numbers, IsEven);

            Console.Write("Пошук чисел більше 5: ");
            FilterArray(numbers, IsGreaterThanFive);

            Console.Write("Пошук непарних чисел (анонімний метод/лямбда): ");
            FilterArray(numbers, x => x % 2 != 0);
            Console.WriteLine();
        }
    }
}