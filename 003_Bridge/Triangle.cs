using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Bridge
{
    public class Triangle : Shape
    {
        Point[] points;

        public Triangle()
        {
            points = new Point[]
            {
                new Point(1, 2),
                new Point(4, -2),
                new Point(1, 52),

            };
        }

        public override void Draw(string color, LineStyle lineStyle)
        {
            base.Draw(color, lineStyle);

            this.ConsoleGraphics.DrawTriangle(color, lineStyle, points);

            this.PrintShapeInfo();
        }

        public override void PrintShapeInfo()
        {
            base.PrintShapeInfo();
            Console.WriteLine("Coords: ");
            foreach (Point p in points)
            {
                Console.WriteLine(p);
            }
        }

    }
}
