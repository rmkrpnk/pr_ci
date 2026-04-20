using System;

namespace practice2
{
    public class UIHealthBar
    {
        public void UpdateHealthBar(int damage, int currentHp)
        {
            Console.WriteLine($"[UIHealthBar] Поточне HP: {currentHp}");
        }
    }
}