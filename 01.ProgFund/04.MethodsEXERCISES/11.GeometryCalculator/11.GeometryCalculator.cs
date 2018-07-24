using System;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            PrintArea(figureType);

            //if (figureType == "triangle")
            //{
            //    double side = double.Parse(Console.ReadLine());
            //    double height = double.Parse(Console.ReadLine());
            //    Console.WriteLine($"{side * height / 2:f2}");
            //}
            //else if (figureType == "square")
            //{
            //    double side = double.Parse(Console.ReadLine());
            //    Console.WriteLine($"{side * side:f2}");
            //}
            //else if (figureType == "rectangle")
            //{
            //    double width = double.Parse(Console.ReadLine());
            //    double height = double.Parse(Console.ReadLine());
            //    Console.WriteLine($"{width * height:f2}");
            //}
            //else if (figureType == "circle")
            //{
            //    double radius = double.Parse(Console.ReadLine());
            //    Console.WriteLine($"{radius * radius * Math.PI:f2}");
            //}
        }

        private static void PrintArea(object figureType)
        {
            switch (figureType)
            {
                case "triangle":
                    PrintTriangleArea();
                    break;
                case "square":
                    PrintSquareArea();
                    break;
                case "rectangle":
                    PrintRectangleArea();
                    break;
                case "circle":
                    PrintCircleArea();
                    break;
            }
        }

        private static void PrintCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = radius * radius * Math.PI;
            Console.WriteLine($"{area:f2}");
        }

        private static void PrintRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width*height;
            Console.WriteLine($"{area:f2}");
        }

        private static void PrintSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"{area:f2}");
        }

        private static void PrintTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height /2;
            Console.WriteLine($"{area:f2}");
        }
    }
}