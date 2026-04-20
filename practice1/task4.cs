using System;
using System.Collections.Generic;

namespace practice1
{
    public class Task4_StandardDelegates
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static void Execute()
        {
            Console.WriteLine("=== Завдання 4: Використання стандартних делегатів (Func та Predicate) ===");

            Func<double, double, double> standardAdd = Add;
            Console.WriteLine($"Використання Func для додавання (20.5 + 10.5): {standardAdd(20.5, 10.5)}");

            List<string> students = new List<string>();
            students.Add("Анна");
            students.Add("Богдан");
            students.Add("Олександр");
            students.Add("Марія");
            students.Add("Олег");

            List<string> namesWithO = students.FindAll(name => name.StartsWith("О"));

            Console.WriteLine("Імена студентів, які починаються на літеру 'О':");
            foreach (string name in namesWithO)
            {
                Console.WriteLine($"- {name}");
            }
            Console.WriteLine();
        }
    }
}