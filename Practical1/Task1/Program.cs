using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetMessage(int num)
        {
            bool res = IsEven(num);
            string answ;
            if (res)
            {
                answ = "Двері відкриваються!";
            }
            else
            {
                answ = "Двері зачинені...";
            }
            return answ;
        }
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter num: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMessage(number));
        }
    }
}
