using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Program
    {
        public static bool IsValidTriangle(double a, double b, double c)
        {
            bool val1;
            bool val2;

            if (a > 0 && b > 0 && c > 0)
            {
                val1 = true;
            }
            else
            {
                val1 = false;
            }

            if ((a + b > c) && (b + c > a) && (c + a > b))
            {
                val2 = true;
            }
            else
            {
                val2 = false;
            }

            if (val1 && val2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            double P = 0;
            if (IsValidTriangle(a, b, c))
            {
                P = a + b + c;
            }
            else 
            {
                throw new ArgumentException();
            }
            return P;

        }

        public static double GetArea(double a, double b, double c)
        {
            double p = 0;
            double area = 0;

            if (IsValidTriangle(a, b, c))
            {
                p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                throw new ArgumentException();
            }
            return area;
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException();
            }
            
            double[] arr = { a, b, c };
            Array.Sort(arr);
            string res = string.Empty;
            if (a == b && b == c)
            {
                res = "рівносторонній";
            }
            else if (a == b || b == c || c == a)
            {
                res = "рівнобедрений";
            }
            else if (Math.Pow(arr[2], 2) == Math.Pow(arr[0], 2) + Math.Pow(arr[1], 2))
            {
                res = "прямокутний";
            }
            else
            {
                res = "довільний";
            }
            return res;
        }


        static void Main(string[] args)
        {
        }
    }
}
