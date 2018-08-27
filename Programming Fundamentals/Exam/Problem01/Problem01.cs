using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace Problem01
{
    class Problem01
    {
        static void Main(string[] args)
        {
            //students per hour
            int empOne = int.Parse(Console.ReadLine());
            int empTwo = int.Parse(Console.ReadLine());
            int empThree = int.Parse(Console.ReadLine());
            int allEmpsPerHour = empOne + empTwo + empThree;


            double numberOfStudents = int.Parse(Console.ReadLine());

            double something = Math.Ceiling(numberOfStudents / allEmpsPerHour);
            double something2 = something / 4;
            double something3 = something + something2;


            Console.WriteLine($"Time needed: {Math.Floor(something3)}h.");
        }
    }
}
