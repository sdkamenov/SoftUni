using System;
using System.Collections.Generic;
using System.Text;

namespace CirclesIntersection
{
    class Circle
    {
        public Circle()
        {

        }
        public Circle(Point point, double radius)
        {
            Point = point;
            Radius = radius;
        }

        public Point Point { get; set; }
        public double Radius { get; set; }
    }
}
