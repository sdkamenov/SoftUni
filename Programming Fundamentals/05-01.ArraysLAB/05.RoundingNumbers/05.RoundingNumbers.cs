using System;
using System.Linq;


namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNumber = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                roundedNumber[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} -> {roundedNumber[i]}");
            }
        }
    }
}
