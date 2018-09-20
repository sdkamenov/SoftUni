using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            //Play around with a queue.You will be given an integer N representing the number of elements to enqueue(add), an integer S representing the number of elements to dequeue(remove) from the queue and finally an integer X, an element that you should look for in the queue.If it is, print true on the console.If it’s not print the smallest element currently present in the queue.If there are no elements in the sequence, print 0 on the console.

            var commands = Console.ReadLine().Split();
            int n = int.Parse(commands[0]);
            int s = int.Parse(commands[1]);
            int x = int.Parse(commands[2]);

            var numbers = Console.ReadLine().Split();
            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(int.Parse(numbers[i]));
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count < 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                var minNumber = queue.ToArray().Min();
                Console.WriteLine(minNumber);
            }
        }
    }
}
