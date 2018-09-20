using System;
using System.Collections.Generic;

namespace ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            var stack = new Stack<string>(numbers);

            foreach (var number in stack)
            {
                Console.Write(number.ToString() + " ");
            }
        }
    }
}
