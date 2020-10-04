using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingFigureFromPoints
{
    class Figure
    {
        Point[] pointArray;
        string figureName;

        public Figure(Point a, Point b, Point c)
        {
            figureName = "triangle";
            pointArray = new Point[3];
            pointArray[0] = a;
            pointArray[1] = b;
            pointArray[2] = c;
        }
       
        public Figure(Point a, Point b, Point c, Point d)
        {
            figureName = "tetragon";
            pointArray = new Point[4];
            pointArray[0] = a;
            pointArray[1] = b;
            pointArray[2] = c;
            pointArray[3] = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            figureName = "pentagon";
            pointArray = new Point[5];
            pointArray[0] = a;
            pointArray[1] = b;
            pointArray[2] = c;
            pointArray[3] = d;
            pointArray[4] = e;
        }

        public double LengthSide(Point a, Point b) => Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));

        public void PerimeterCalculator()
        {
            double perimeter = 0;

            for (int i = 0; i < pointArray.Length - 1; i++)
            {
                perimeter += LengthSide(pointArray[i], pointArray[i + 1]);
            }
            perimeter = perimeter + LengthSide(pointArray[pointArray.Length - 1], pointArray[0]);

            Console.WriteLine($"Perimeter of the {figureName} equals to {perimeter}");
        }


    }
}
