using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryB
{
    class Rectangle
    {
        public Point TopLeft { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double len, double wid)
        {
            Length = len;
            Width = wid;
        }

  
    }
}
