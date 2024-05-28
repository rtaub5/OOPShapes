using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryB
{
    class Point
    {
        public double Xcoord { get; set; }
        public double Ycoord { get; set; }
        public Point(double x, double y)
        {
            Xcoord = x; Ycoord = y;
        }
        public double Rcoord()
        {
            return Math.Sqrt(Xcoord * Xcoord + Ycoord * Ycoord);
        }

        public double Theta()
        {
            return Math.Atan2(Ycoord, Xcoord);
        }
    }
}
