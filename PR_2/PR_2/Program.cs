using PR_2.Pr_2._2;

namespace PR_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TemparatureSencor temparatureSencor = new TemparatureSencor();
            //Display display = new Display();
            //AirConditioner airConditioner = new AirConditioner();
            //SecuritySystem securitySystem = new SecuritySystem();

            //temparatureSencor.OnTemperatureChanged += display.ShowTemperature;
            //temparatureSencor.OnTemperatureChanged += airConditioner.ReactToTemperatureChange;
            //temparatureSencor.OnTemperatureChanged += securitySystem.CheckTemparature;

            //temparatureSencor.SetTemperature(10);
            //Console.WriteLine("================");
            //temparatureSencor.SetTemperature(4);
            //Console.WriteLine("================");

            //temparatureSencor.SetTemperature(20);
            //Console.WriteLine("================");

            //temparatureSencor.SetTemperature(17);

            Player player = new Player(100);

            GameLogger gameLogger = new GameLogger();
            SoundSystem soundSystem = new SoundSystem();
            UIHealthBar uiHealthBar = new UIHealthBar();

            gameLogger.SubscribeToPlayer(player);
            soundSystem.SubscribeToPlayer(player);
            uiHealthBar.SubscribeToPlayer(player);
            gameLogger.SubscribeToPlayer(player);

            player.GetDamage(30);

            player.GetDamage(30);

            player.GetDamage(30);




        }
    }
}
