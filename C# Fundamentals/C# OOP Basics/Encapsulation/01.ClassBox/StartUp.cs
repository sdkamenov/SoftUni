﻿using System;

namespace _01.ClassBox
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);
                Console.WriteLine(box.SurfaceArea);
                Console.WriteLine(box.LateralSurfaceArea);
                Console.WriteLine(box.Volume);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}
