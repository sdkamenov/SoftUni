using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            //Play around with a stack.You will be given an integer N representing the number of elements to push onto the stack, an integer S representing the number of elements to pop from the stack and finally an integer X, an element that you should look for in the stack.If it’s found, print “true” on the console.If it isn’t, print the smallest element currently present in the stack.

            var commands = Console.ReadLine().Split();
            int n = int.Parse(commands[0]);
            int s = int.Parse(commands[1]);
            int x = int.Parse(commands[2]);

            var numbers = Console.ReadLine().Split();
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(numbers[i]));
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count < 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                var minNumber = stack.ToArray().Min();
                Console.WriteLine(minNumber);
            }
        }

    }

}