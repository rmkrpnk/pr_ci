using System;

namespace practice2
{
    public class AchievementSystem
    {
        private bool _halfHealthAwarded = false;
        private bool _firstDeathAwarded = false;

        public void CheckAchievements(int damage, int currentHp)
        {
            if (currentHp <= 50 && !_halfHealthAwarded)
            {
                Console.WriteLine("[AchievementSystem] Здобуто досягнення: 'Half Health'!");
                _halfHealthAwarded = true;
            }

            if (currentHp <= 0 && !_firstDeathAwarded)
            {
                Console.WriteLine("[AchievementSystem] Здобуто досягнення: 'First Death'!");
                _firstDeathAwarded = true;
            }
        }
    }
}