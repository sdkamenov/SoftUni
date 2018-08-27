using System;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Collections.Generic;

namespace SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }

            int remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(numAsString[i].ToString());

                int currentSum = digit * multiplier + remainder;
                remainder = currentSum / 10;

                result.Append(currentSum % 10);
            }
            result.Append(remainder);

            var output = result.ToString().TrimEnd('0').ToArray().Reverse().ToArray();
            Console.WriteLine(output);
        }
    }
}
