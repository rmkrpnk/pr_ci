using System;

namespace practice1
{
    public class Task6_DynamicValidator
    {
        public delegate bool Validator(string text);

        public static Validator GetValidator(int minLength)
        {
            return (string text) =>
            {
                return text.Length >= minLength;
            };
        }

        public static void Execute()
        {
            Console.WriteLine("=== Завдання 6: Динамічний валідатор тексту ===");

            Validator passwordValidator = GetValidator(8);
            Validator loginValidator = GetValidator(3);

            string inputLogin1 = "as";
            string inputLogin2 = "admin";
            string inputPassword1 = "12345";
            string inputPassword2 = "StrongPass2025!";

            Console.WriteLine($"Перевірка логіна '{inputLogin1}': {loginValidator(inputLogin1)}");
            Console.WriteLine($"Перевірка логіна '{inputLogin2}': {loginValidator(inputLogin2)}");

            Console.WriteLine($"Перевірка пароля '{inputPassword1}': {passwordValidator(inputPassword1)}");
            Console.WriteLine($"Перевірка пароля '{inputPassword2}': {passwordValidator(inputPassword2)}");
            Console.WriteLine();
        }
    }
}