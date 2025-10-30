namespace SmartHomeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeController controller = new SmartHomeController();

            Light lampa = new Light() { Name = "Лампа у вітальні" };
            AirConditioner condicioner = new AirConditioner() { Name = "Кондиціонер у спальні" };
            CoffeeMachine cofeBaba = new CoffeeMachine() { Name = "Кавомашина на кухні" };
            MotionSensor sensor = new MotionSensor() { Name = "Датчик руху у коридорі" };

            controller.AddDevice(lampa);
            controller.AddDevice(condicioner);
            controller.AddDevice(cofeBaba);
            controller.AddDevice(sensor);
            Console.WriteLine("\n");

            controller.AddEnergyDevice(lampa);
            controller.AddEnergyDevice(condicioner);
            controller.AddEnergyDevice(cofeBaba);

            controller.TurnAllOn();
            Console.WriteLine("\n");

            lampa.PrintStatus();
            condicioner.PrintStatus();
            cofeBaba.PrintStatus();
            sensor.PrintStatus();
            Console.WriteLine("\n");

            controller.ShowEnergyReport(5);

            controller.TurnAllOff();


        }
    }
}
