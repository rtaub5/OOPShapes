using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryB
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(new Point(0, 0), 1.0);
            Square square = new Square(1.0);
            Rectangle rectangle = new Rectangle(2.0, 1.0);
            Parallelogram parallelogram = new Parallelogram(3.0, 2.0, 1.0);

            ShowFigures(circle, square, rectangle, parallelogram);
            var waitForUser = Console.ReadKey();
        }

        private static void ShowFigures(Circle circle, Square square, Rectangle rectangle, Parallelogram parallelogram)
        {
            Console.Out.WriteLine($"Circle area: {Geometry.GetArea(circle)}");
            Console.Out.WriteLine($"Square area: {Geometry.GetArea(square)}");
            Console.Out.WriteLine($"Rectangle area: {Geometry.GetArea(rectangle)}");
            Console.Out.WriteLine($"Parallelogram area: {Geometry.GetArea(parallelogram)}");
            Console.Out.WriteLine($"Circle perimeter: {Geometry.GetPerimeter(circle)}");
            Console.Out.WriteLine($"Square perimeter: {Geometry.GetPerimeter(square)}");
            Console.Out.WriteLine($"Rectangle perimeter: {Geometry.GetPerimeter(rectangle)}");
            Console.Out.WriteLine($"Parallelogram perimeter: {Geometry.GetPerimeter(parallelogram)}");
        }
    }
}
