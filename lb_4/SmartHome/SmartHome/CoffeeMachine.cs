using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {
        public string DeviceName => Name;

        public int PowerConsumption { get; set; } = 1000;
        //public CoffeeMachine()
        //{
        //    DeviceName = Name;
        //}
        public double GetEnergyUsage(int hours)
        {
            double energyUsage = 0;
            if (IsOn)
            {
                energyUsage = (PowerConsumption * hours) / 1000.0;
                return energyUsage;
            }
            else
            {
                return energyUsage;
            }
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} завершила роботу.");
            IsOn = false;
        }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} почала готувати каву.");
            IsOn = true;
        }
    }
}
