using System;

namespace practice1
{
    public class Task1_Calculator
    {
        public delegate double MathOperation(double a, double b);
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Помилка: Ділення на нуль!");
                return 0;
            }
            return a / b;
        }
        public static void Execute()
        {
            Console.WriteLine("=== Завдання 1: Калькулятор ===");

            MathOperation operation;

            double num1 = 10.5;
            double num2 = 2.0;

            operation = Add;
            Console.WriteLine($"Додавання: {num1} + {num2} = {operation(num1, num2)}");

            operation = Subtract;
            Console.WriteLine($"Віднімання: {num1} - {num2} = {operation(num1, num2)}");

            operation = Multiply;
            Console.WriteLine($"Множення: {num1} * {num2} = {operation(num1, num2)}");

            operation = Divide;
            Console.WriteLine($"Ділення: {num1} / {num2} = {operation(num1, num2)}");
            Console.WriteLine();
        }
    }
}