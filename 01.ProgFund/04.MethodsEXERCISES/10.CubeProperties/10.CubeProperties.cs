using System;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                double face = Math.Sqrt(2 * side * side);
                Console.WriteLine($"{face:f2}");
            }
            else if (parameter == "space")
            {
                double space = Math.Sqrt(3 * side * side);
                Console.WriteLine($"{space:f2}");
            }
            else if (parameter == "volume")
            {
                double volume = Math.Pow(side, 3);
                Console.WriteLine($"{volume:f2}");
            }
            else if (parameter == "area")
            {
                double area = 6 * side * side;
                Console.WriteLine($"{area:f2}");
            }
        }
    }
}
