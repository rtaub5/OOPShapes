using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryA
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(new Point(), 1.0);
            Square square = new Square(1.0);
            Rectangle rectangle = new Rectangle(2.0, 1.0);
            Parallelogram parallelogram = new Parallelogram(3.0, 2.0, 1.0);

            IShape[] shapes = { circle, square, rectangle, parallelogram };
            foreach (IShape shape in shapes)
            {
                ShowFigure(shape);
            }
            var waitForUser = Console.ReadKey();
        }

        private static void ShowFigure(IShape shape)
        {
            String Iam = shape.GetType().ToString();
            //Iam = Iam.Substring(1 + Iam.LastIndexOf('.'));
            Console.Out.WriteLine($"{Iam} area: {shape.GetArea()}");
            Console.Out.WriteLine($"{Iam} perimeter: {shape.GetPerimeter()}");
        }
    }
}
