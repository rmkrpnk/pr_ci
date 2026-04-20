using System;

namespace practice1
{
    public class Task2_Multicasting
    {
        public delegate void NotificationHandler(string message);

        public static void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: [{message}]");
        }

        public static void SendSMS(string message)
        {
            Console.WriteLine($"SMS sent: [{message}]");
        }

        public static void Execute()
        {
            Console.WriteLine("=== Завдання 2: Мультикастинг ===");

            NotificationHandler notify = SendEmail;

            notify += SendSMS;

            notify("Ваше замовлення успішно оброблено!");
            Console.WriteLine();
        }
    }
}