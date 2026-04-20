using System;

namespace practice2
{
    public class Task1_Runner
    {
        public static void Execute()
        {
            Console.WriteLine("========== ЗАВДАННЯ 1: СИСТЕМА КЛІМАТ-КОНТРОЛЮ ==========");

            TemperatureSensor sensor = new TemperatureSensor();

            Display display = new Display();
            AirConditioner ac = new AirConditioner();
            SecuritySystem security = new SecuritySystem();

            sensor.OnTemperatureChanged += display.UpdateDisplay;
            sensor.OnTemperatureChanged += ac.ReactToTemperature;
            sensor.OnTemperatureChanged += security.CheckSafety;

            sensor.SetTemperature(20);
            sensor.SetTemperature(30);
            sensor.SetTemperature(45);
            sensor.SetTemperature(10);
            sensor.SetTemperature(2);

            Console.WriteLine();
        }
    }
}