using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CreatingFigureFromPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure myFigure = new Figure(new Point(0, 0, "A"), new Point(0, 5, "B"), new Point(5, 5, "C"), new Point (5, 0, "D"));
            myFigure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
