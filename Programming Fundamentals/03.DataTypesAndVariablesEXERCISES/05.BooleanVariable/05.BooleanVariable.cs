using System;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool convertedBool = Convert.ToBoolean(Console.ReadLine());
            if (convertedBool)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
