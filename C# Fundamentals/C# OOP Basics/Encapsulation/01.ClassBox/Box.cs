using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public string SurfaceArea
        {
            get => this.PrintSurfaceArea();
        }
        private string PrintSurfaceArea()
        {
            //2lw + 2lh + 2wh
            double surfaceArea = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return $"Surface Area - {surfaceArea:f2}";
        }


        public string LateralSurfaceArea
        {
            get => this.PrintLateralSurfaceArea();
        }
        private string PrintLateralSurfaceArea()
        {
            //2lh + 2wh
            double lateralSurfaceArea = 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
        }

        public string Volume
        {
            get => this.PrintVolume();
        }
        private string PrintVolume()
        {
            //lwh
            double volume = this.Length * this.Width * this.Height;
            return $"Volume - {volume:f2}";
        }

        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }
        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }
    }
}
