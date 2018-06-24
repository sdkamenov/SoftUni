using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace UnicodeCharacters
{
    class UnicodeCharacters 
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            foreach (var letter in input)
            {
                Console.Write($"\\u{(int)letter:x4}");
            }
            Console.WriteLine();
        }
    }
}
