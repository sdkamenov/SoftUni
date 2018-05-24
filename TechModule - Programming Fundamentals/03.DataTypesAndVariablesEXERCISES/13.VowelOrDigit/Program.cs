using System;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            if (n == 'a' || n == 'e' || n == 'o' || n == 'u' || n == 'i' || n == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(n))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
