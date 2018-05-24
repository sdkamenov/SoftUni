using System;

namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexOne = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(hexOne);
        }
    }
}
