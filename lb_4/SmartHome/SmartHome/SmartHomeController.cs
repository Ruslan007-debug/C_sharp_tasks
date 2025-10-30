using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        List<ISwitchable> switchDevices = new List<ISwitchable>();
        List<IEnergyConsumer> energyDevices = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device)
        {
            switchDevices.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDevices.Add(device);
        }

        public void TurnAllOn()
        {
            foreach (ISwitchable device in switchDevices)
            {
                device.TurnOn();
            }
        }

        public void TurnAllOff()
        {
            foreach (ISwitchable device in switchDevices)
            {
                device.TurnOff();
            }
        }


        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine("Звіт про споживання енергії за 5 год:");
            double sumUsage = 0.0;
            foreach (IEnergyConsumer device in energyDevices)
            {
                double enerUsage = device.GetEnergyUsage(hours);
                sumUsage += enerUsage;
                Console.WriteLine($"{device.DeviceName}: {enerUsage:F2} кВт·год (потужність: {device.PowerConsumption} Вт)");                
            }
            Console.WriteLine($"Загальне споживання: {sumUsage:F2} кВт·год" +
                $"\r\nВартість (~4 грн/кВт·год): {sumUsage * 4:F2} грн\r\n");


        }

    }
}
