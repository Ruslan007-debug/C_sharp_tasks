using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class AirConditioner : Device, IEnergyConsumer 
    {
        public string DeviceName => Name;

        public int PowerConsumption { get; set; } = 2000;

        //public AirConditioner()
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
            Console.WriteLine($"{Name} зупинено.");
            IsOn = false;
        }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} почав охолодження.");
            IsOn = true;
        }
    }
}
