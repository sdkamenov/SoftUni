using System;

namespace _01.PracticeIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte firstNUmber = sbyte.Parse(Console.ReadLine());
            byte secondNumber = byte.Parse(Console.ReadLine());
            short thirdNumber = short.Parse(Console.ReadLine());
            ushort fourthNumber = ushort.Parse(Console.ReadLine());
            uint fifthNumber = uint.Parse(Console.ReadLine());
            int sixthNumber = int.Parse(Console.ReadLine());
            long seventhNumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNUmber}");
            Console.WriteLine($"{secondNumber}");
            Console.WriteLine($"{thirdNumber}");
            Console.WriteLine($"{fourthNumber}");
            Console.WriteLine($"{fifthNumber}");
            Console.WriteLine($"{sixthNumber}");
            Console.WriteLine($"{seventhNumber}");

        }
    }
}
