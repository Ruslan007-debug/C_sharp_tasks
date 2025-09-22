using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        public static string ClassifyAge(int age)
        {
            string answ = string.Empty;

            if (age < 0 || age > 120)
            {
                answ = "Нереальний вік";
            }
            else if (age <= 11)
            {
                answ = "Ви дитина";
            }
            else if (age >= 12 && age <= 17)
            {
                answ = "Підліток";
            }
            else if (age >= 18 && age <= 59)
            {
                answ = "Дорослий";
            }
            else if (age >= 60)
            {
                answ = "Пенсіонер";
            }

            return answ;
        }
        static void Main(string[] args)
        {
            int age;
            Console.Write("Write your age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(ClassifyAge(age));

        }
    }
}
