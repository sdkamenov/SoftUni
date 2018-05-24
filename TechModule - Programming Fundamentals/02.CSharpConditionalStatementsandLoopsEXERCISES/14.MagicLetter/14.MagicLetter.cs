using System;

namespace _14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char firstPosition = firstLetter; firstPosition <= secondLetter; firstPosition++)
            {
                for (char middlePosition = firstLetter; middlePosition <= secondLetter; middlePosition++)
                {
                    for (char lastPosition = firstLetter; lastPosition <= secondLetter; lastPosition++)
                    {
                        if (firstPosition != thirdLetter && middlePosition != thirdLetter && lastPosition != thirdLetter)
                        {
                            Console.Write($"{firstPosition}{middlePosition}{lastPosition} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
