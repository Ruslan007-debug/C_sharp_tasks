using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace PR_1
{
    public class Program
    {
        public delegate double MathOperation(double x, double y);
        static double Add(double x, double y) 
        {
                return x + y;
        }
        static double Subtract(double x, double y) => x - y;
        static double Multiply(double x, double y) => x * y;
        static double Divide(double x, double y) => x / y;



        public delegate void HandleMessage(string message);
        static void SendEmail(string message) => Console.WriteLine($"Email: {message}");
        static void SendSMS(string message) => Console.WriteLine($"SMS: {message}");


        public delegate bool FilterPredicate(int a);
        public static bool IsEven(int a) => a % 2 == 0&&a>5;
        public static bool IsGreaterThanFive(int a) => a > 5;

        public static void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (predicate(numbers[i]))
                {
                    Console.WriteLine($"chosed numbers: {numbers[i]}\n");
                }

            }
        }

        public static void Main(string[] args)
        {
            //1
            MathOperation operation;
            operation = Add;
            Console.WriteLine($"Sum: {operation(5, 4)}");
            operation += Subtract;
            Console.WriteLine($"Sub: {operation(4, 2)}");
            operation += Multiply;
            Console.WriteLine($"Mult: {operation(2, 5)}");
            operation += Divide;
            Console.WriteLine($"Div: {operation(4, 2)}");



            //2
            HandleMessage messageHandler;
            messageHandler = SendEmail;
            messageHandler+= SendSMS;
            messageHandler("Hello, World!");


            //3
            int[] numbers = { 1, 2, 4, 5, 6, 12, 54, 66, 2, 11 };
            FilterPredicate filter1 = IsEven;
            FilterArray(numbers, filter1);
            //FilterPredicate filter2 = IsGreaterThanFive;
            //FilterArray(numbers, filter2);

        }
        
    }
}
