using System;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            object firstSecondWord = firstWord + " " + secondWord;
            string greeting = firstSecondWord.ToString();
            Console.WriteLine(greeting);
        }
    }
}
