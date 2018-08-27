using System;

namespace _02.PracticeFloatingPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            decimal thirdNumber = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber}");
            Console.WriteLine($"{secondNumber}");
            Console.WriteLine($"{thirdNumber}");
        }
    }
}
