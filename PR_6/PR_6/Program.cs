namespace PR_6
{
    public class Program
    {

        private static volatile bool _isPaused = false;
        private static volatile bool _isRunning = true;
        private static readonly object _locker = new object();
        private static int _counter = 0;
        private static ConsoleColor _color = ConsoleColor.White;



        static void CounterLoop()
        {
            while (_isRunning)
            {
                if (!_isPaused)
                {
                    int current;

                    lock (_locker)
                    {
                        _counter++;
                        current = _counter;
                    }

                    
                    Console.ForegroundColor = _color;
                    Console.WriteLine($"Counter: {current}");
                    Console.ResetColor();
                }

                Thread.Sleep(1000); 
            }

            Console.WriteLine("Програма завершена.");
        }

        
        static void KeyboardListener()
        {
            
            while (_isRunning)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                

                switch (key)
                {
                    case ConsoleKey.P:
                        _isPaused = !_isPaused;
                        string status = _isPaused ? "Пауза" : "Продовження";
                        Console.WriteLine($"\n{status}");
                        break;

                    case ConsoleKey.R:
                        lock (_locker) 
                        {
                            _counter = 0;
                        }
                        Console.WriteLine("\nСкинуто до 0");
                        break;

                    case ConsoleKey.C:
                        ChangeColor();
                        break;

                    case ConsoleKey.Q:
                        _isRunning = false; 
                        Console.WriteLine("\nЗавершення");
                        break;
                }
            }
        }

        
        static void ChangeColor()
        {
            
            ConsoleColor[] colors = 
            {
            ConsoleColor.White,
            ConsoleColor.Green,
            ConsoleColor.Cyan,
            ConsoleColor.Yellow,
            ConsoleColor.Magenta
            };

            
            int idx = Array.IndexOf(colors, _color);
            _color = colors[(idx + 1) % colors.Length];

            Console.WriteLine($"\nКолір змінено");
        }


        static void Main()
        {
            Console.WriteLine("Програма запущена");
            Console.WriteLine("P=Пауза | R=Скинути | C=Колір | Q=Вихід");
            Console.WriteLine("─────────────────────────────────────────");

            Thread keyThread = new Thread(KeyboardListener);
            keyThread.IsBackground = true; 
            keyThread.Start();

            CounterLoop();
        }

        
    }
}
