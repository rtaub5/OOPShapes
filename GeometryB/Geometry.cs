using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryB
{
    class Geometry
    {
        public static double GetArea(Object shape)
        {
            double area = 0.0;
            if (shape is Square)
            {
                Square thisSquare = (Square)shape;
                area = thisSquare.Side * thisSquare.Side;
            }
            else if (shape is Rectangle)
            {
                Rectangle thisRectangle = (Rectangle)shape;
                area = thisRectangle.Length * thisRectangle.Width;
            }
            else if (shape is Circle)
            {
                Circle thisCircle = (Circle)shape;
                area = Math.PI * thisCircle.Radius * thisCircle.Radius;
            }
            else if (shape is Parallelogram)
            {
                Parallelogram thisParallelogram = (Parallelogram)shape;
                area = thisParallelogram.Base * thisParallelogram.Height;
            }
            else
            {
                throw new NoSuchShapeException();
            }
            return area;
        }

        public static double GetPerimeter(Object shape)
        {
            double perimeter = 0.0;
            if (shape is Square)
            {
                Square thisSquare = (Square)shape;
                perimeter = thisSquare.Side * 4;
            }
            else if (shape is Rectangle)
            {
                Rectangle thisRectangle = (Rectangle)shape;
                perimeter = (2 * thisRectangle.Length)  + (2 * thisRectangle.Width);
            }
            else if (shape is Circle)
            {
                Circle thisCircle = (Circle)shape;
                perimeter =  Math.PI * 2 * thisCircle.Radius;
            }
            else if (shape is Parallelogram)
            {
                Parallelogram thisParallelogram = (Parallelogram)shape;
                perimeter = (2 * thisParallelogram.Side) + (2 * thisParallelogram.Base);
            }
            else
            {
                throw new NoSuchShapeException();
            }
            return perimeter;


        }

    }
}
