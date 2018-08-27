using System;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversed = ReversedInput(input);
            Console.WriteLine(reversed);
        }

        static string ReversedInput(string input)
        {
            string reversed = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            return reversed;
        }
    }
}
