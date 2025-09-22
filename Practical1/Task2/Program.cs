using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
            }
            return array;
        }

        public static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static double GetAverage(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
        public static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public static int GetMax(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] array;
            int sum, maxRes, minRes;
            double aver;
            Console.Write("enter number of numbers: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("write minimal array element: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("write maximum array element: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Your array:");
            array = GenerateRandomArray(size, min, max);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i == array.Length - 1)
                {
                    Console.WriteLine(".");
                    break;
                }
                Console.Write(", ");
            }
            sum = GetSum(array);
            Console.WriteLine($"Sum of array: {sum}");

            aver = GetAverage(array);
            Console.WriteLine($"Average number: {aver}");

            min = GetMin(array);
            Console.WriteLine($"Minimal array element: {min}");

            max = GetMax(array);
            Console.WriteLine($"Maximal array element: {max}");

        }
    }
}
