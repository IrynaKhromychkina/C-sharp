using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingFigureFromPoints
{
    class Point
    {
        private int x, y;
        private string pointName;

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public string PointName
        {
            get
            {
                return pointName;
            }
        }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            pointName = name;
        }




    }
}
