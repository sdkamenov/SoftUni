using System;

namespace _03.PracticeCharsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            char secondLine = char.Parse(Console.ReadLine());
            char thirdLine = char.Parse(Console.ReadLine());
            char fourthLine = char.Parse(Console.ReadLine());
            string fifthLine = Console.ReadLine();

            Console.WriteLine($"{firstLine}");
            Console.WriteLine($"{secondLine}");
            Console.WriteLine($"{thirdLine}");
            Console.WriteLine($"{fourthLine}");
            Console.WriteLine($"{fifthLine}");
        }
    }
}
