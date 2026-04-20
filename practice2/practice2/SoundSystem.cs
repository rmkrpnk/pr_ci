using System;

namespace practice2
{
    public class SoundSystem
    {
        public void PlayDamageSound(int damage, int currentHp)
        {
            Console.WriteLine("[SoundSystem] *Відтворюється звук 'Ой!'*");

            if (currentHp <= 20 && currentHp > 0)
            {
                Console.WriteLine("[SoundSystem] *Відтворюється звук 'Серцебиття' (Критичний стан)*");
            }
        }
    }
}