using System;

namespace practice2
{
    public class SecuritySystem
    {
        public void CheckSafety(int temperature)
        {
            if (temperature > 40)
            {
                Console.WriteLine("[Security System] УВАГА! КРИТИЧНИЙ ПЕРЕГРІВ! Можлива пожежа!");
            }
            else if (temperature < 5)
            {
                Console.WriteLine("[Security System] УВАГА! РИЗИК ЗАМЕРЗАННЯ ТРУБ ТА СИСТЕМ!");
            }
        }
    }
}