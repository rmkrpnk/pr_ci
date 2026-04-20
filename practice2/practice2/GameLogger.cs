using System;

namespace practice2
{
    public class GameLogger
    {
        public void LogDamage(int damage, int currentHp)
        {
            Console.WriteLine($"[GameLogger] LOG: Отримано урону: {damage}. Залишилось HP: {currentHp}. Час: {DateTime.Now:HH:mm:ss}");
        }
    }
}