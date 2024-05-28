using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryB
{
    class Parallelogram
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
    }
}
