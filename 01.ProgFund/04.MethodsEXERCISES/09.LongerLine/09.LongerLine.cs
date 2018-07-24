﻿using System;

namespace LongerLine
{
    public class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        public static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double xy12 = CalculatePythagorean(Math.Pow(x2 - x1, 2), Math.Pow(y2 - y1, 2));

            double xy34 = CalculatePythagorean(Math.Pow(x4 - x3, 2), Math.Pow(y4 - y3, 2));

            if (xy12 >= xy34)
            {
                PrintCloserLine(x1, y1, x2, y2);
            }
            else
            {
                PrintCloserLine(x3, y3, x4, y4);
            }
        }

        public static void PrintCloserLine(double x1, double y1, double x2, double y2)
        {
            double xy1 = CalculatePythagorean(x1, y1);
            double xy2 = CalculatePythagorean(x2, y2);

            if (xy1 <= xy2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }

        }

        public static double CalculatePythagorean(double x, double y)
        {
            double result = Math.Sqrt(x * x + y * y);
            return result;
        }
    }
}
