using System;

namespace practice2
{
    public class Task2_Runner
    {
        public static void Execute()
        {
            Console.WriteLine("========== ЗАВДАННЯ 2: GAMEDEV (ОБРОБКА УРОНУ) ==========");

            Player player = new Player(100);

            UIHealthBar healthBar = new UIHealthBar();
            SoundSystem sound = new SoundSystem();
            AchievementSystem achievements = new AchievementSystem();
            GameLogger logger = new GameLogger();

            player.OnDamageTaken += healthBar.UpdateHealthBar;
            player.OnDamageTaken += sound.PlayDamageSound;
            player.OnDamageTaken += achievements.CheckAchievements;
            player.OnDamageTaken += logger.LogDamage;

            player.TakeDamage(20);
            player.TakeDamage(40);
            player.TakeDamage(25);
            player.TakeDamage(30);

            Console.WriteLine();
        }
    }
}