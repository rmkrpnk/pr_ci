using System;

namespace practice2
{
    public class Player
    {
        public event Action<int, int> OnDamageTaken;

        public int HP { get; private set; }

        public Player(int maxHp)
        {
            HP = maxHp;
            Console.WriteLine($"[Гравець] Створено. Стартове HP: {HP}");
        }

        public void TakeDamage(int damage)
        {
            HP -= damage;

            if (HP < 0)
            {
                HP = 0;
            }

            Console.WriteLine($"\n--- Гравець отримує {damage} урону ---");

            OnDamageTaken?.Invoke(damage, HP);
        }
    }
}