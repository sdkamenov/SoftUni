using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsToPass = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var queue = new Queue<string>();
            var count = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
