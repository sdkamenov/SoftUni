using System;
using System.Collections.Generic;

namespace SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            int counter = 0;

            queue.Enqueue(number);

            while (counter < 50)
            {
                long currentNumber = queue.Peek();

                queue.Enqueue(currentNumber + 1);
                queue.Enqueue(2 * currentNumber + 1);
                queue.Enqueue(currentNumber + 2);


                Console.Write(queue.Dequeue() + " ");
                counter++;
            }
        }
    }
}
