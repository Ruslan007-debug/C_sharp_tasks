using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Program
    {
        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return (double)sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < min)
                {
                    min = marks[i];
                }
            }
            return min;
        }

        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (max < marks[i])
                {
                    max = marks[i];
                }
            }
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.Write($"Група {i + 1}: Середній = {Math.Round(GetAverage(groups[i]))}," +
                    $" Мінімальний = {GetMin(groups[i])}, Максимальний = {GetMax(groups[i])}\n");

            }
        }

        static void Main(string[] args)
        {

            int[][] groups = new int[3][];

            groups[0] = new int[] { 56, 90, 100, 64, 75, 82 };
            groups[1] = new int[] { 50, 65, 90, 91, 85 };
            groups[2] = new int[] { 90, 92, 95, 100, 98, 60, 62 };

            PrintGroupStatistics(groups);
        }

    }
}
