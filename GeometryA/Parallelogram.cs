using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryA
{
    class Parallelogram : IShape
    {
        public Point TopLeft { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }
        public double Side { get; set; }
        public Parallelogram(double ba, double he, double si)
        {
            Base = ba;
            Height = he;
            Side = si;
        }

        public double GetArea()
        {
            return Base * Height;
        }

        public double GetPerimeter()
        {
            return (Side * 2) + (Height * 2);
        }
    }
}

