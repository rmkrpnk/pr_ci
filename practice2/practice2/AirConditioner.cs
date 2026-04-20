using System;

namespace practice2
{
    public class AirConditioner
    {
        public void ReactToTemperature(int temperature)
        {
            if (temperature < 17)
            {
                Console.WriteLine("[AirConditioner] Режим: УВІМКНЕНО ОБІГРІВ (Холодно)");
            }
            else if (temperature >= 17 && temperature <= 25)
            {
                Console.WriteLine("[AirConditioner] Режим: ВИМКНЕНО (Оптимальна температура)");
            }
            else if (temperature > 25)
            {
                Console.WriteLine("[AirConditioner] Режим: УВІМКНЕНО ОХОЛОДЖЕННЯ (Спекотно)");
            }
        }
    }
}