﻿using System;

namespace _03.Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string driver = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driver);

            Console.WriteLine(ferrari);
        }
    }
}
