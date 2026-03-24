using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2
{
    internal class TemparatureSencor
    {
        public event Action<double> OnTemperatureChanged;

        private double _temperature;

        public void SetTemperature(double newTemperature)
        {
            _temperature = newTemperature;
            Console.WriteLine($"Current temparature: {newTemperature}");
            OnTemperatureChanged?.Invoke(_temperature);
        }
    }
}
