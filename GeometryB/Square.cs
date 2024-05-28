using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryB
{
    class Square
    {
        public Point TopLeft { get; set; }
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }
    }
}
