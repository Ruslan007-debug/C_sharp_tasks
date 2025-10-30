using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public abstract class Device : ISwitchable
    {
        public string Name { get; set; }
        public bool IsOn { get; protected set; }

        public abstract void TurnOff();


        public abstract void TurnOn();

        public void PrintStatus()
        {
            if (IsOn)
            {
                Console.WriteLine($"{Name}: увімкнено");
            }
            else 
            {
                Console.WriteLine($"{Name}: вимкнено");
            }
            
        }
    }
}
