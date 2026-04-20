using System;

namespace practice2
{
    public class TemperatureSensor
    {
        public event Action<int> OnTemperatureChanged;

        private int _currentTemperature;

        public void SetTemperature(int newTemperature)
        {
            _currentTemperature = newTemperature;
            Console.WriteLine($"\n[Датчик] Температура змінилася на: {_currentTemperature}°C");

            OnTemperatureChanged?.Invoke(_currentTemperature);
        }
    }
}