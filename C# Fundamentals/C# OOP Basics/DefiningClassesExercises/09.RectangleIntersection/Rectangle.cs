using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public string Id
        {
            get { return id; }
        }

        public Rectangle()
        {
        }

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public bool IntersectsWith(Rectangle r)
        {
            if ((r.y >= this.y && r.y - r.height <= this.y && r.x <= this.x && r.x + r.width >= this.x) ||
            (r.y >= this.y && r.y - r.height <= this.y && r.x >= this.x && r.x <= this.x + this.width) ||
            (r.y <= this.y && r.y >= this.y - this.height && r.x <= this.x && r.x + r.width >= this.x) ||
            (r.y <= this.y && r.y >= this.y - this.height && r.x >= this.x && r.x <= this.x + this.width))
            {
                return true;
            }

            return false;
        }
    }
}
