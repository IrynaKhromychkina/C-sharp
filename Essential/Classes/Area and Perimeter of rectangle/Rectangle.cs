using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAreaAndPerimeter
{
    class Rectangle
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        static double AreaCalculator(double width, double height) => (width * height);

        static double PerimeterCalculator(double width, double height) => (2 * (width + height));

        public double Area
        {
            get
            {
                return Rectangle.AreaCalculator(width, height);
            }
        }

        public double Perimeter
        {
            get
            {
                return Rectangle.PerimeterCalculator(width, height);
            }
        }

    }
}
