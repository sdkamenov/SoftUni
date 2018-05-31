using System;

namespace CenterPoint
{
    public class CentralPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintCloserLine(x1, y1, x2, y2);
        }

        public static void PrintCloserLine(double x1, double y1, double x2, double y2)
        {
            double xy1 = CalculatePythagorean(x1, y1);
            double xy2 = CalculatePythagorean(x2, y2);

            if (xy1 <= xy2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }

        }

        public static double CalculatePythagorean(double x, double y)
        {
            double result = Math.Sqrt(x * x + y * y);
            return result;
        }
    }
}
