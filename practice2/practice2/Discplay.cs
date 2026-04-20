using System;

namespace practice2
{
    public class Display
    {
        public void UpdateDisplay(int temperature)
        {
            Console.WriteLine($"[Display] Поточна температура на екрані: {temperature}°C");
        }
    }
}