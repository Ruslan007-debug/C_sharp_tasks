using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class Light : Device, IEnergyConsumer
    {
        public string DeviceName => Name; 

        public int PowerConsumption { get; protected set; } = 60;

        //public Light() {
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
            Console.WriteLine($"{Name} вимкнена.");
            IsOn = false;
        }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} засвітилася.");
            IsOn = true;
        }

    }
}
