using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < commands[0]; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string id = input[0];
                double width = double.Parse(input[1]);
                double height = double.Parse(input[2]);
                double x = double.Parse(input[3]);
                double y = double.Parse(input[4]);

                Rectangle rectangle = new Rectangle(id, width, height, x, y);
                rectangles.Add(rectangle);
            }

            for (int j = 0; j < commands[1]; j++)
            {
                string[] checks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstRect = checks[0];
                string secondRect = checks[1];

                Rectangle firstRectangle = rectangles.First(r => r.Id == firstRect);
                Rectangle secondRectangle = rectangles.First(r => r.Id == secondRect);

                if (firstRectangle.IntersectsWith(secondRectangle))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
