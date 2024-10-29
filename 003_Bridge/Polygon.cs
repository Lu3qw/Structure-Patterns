using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Bridge
{
    public class Polygon : Shape
    {
        Point[] points;

        public Polygon()
        {
            points = new Point[]
            {
                new Point(1, 2),
                new Point(4, -2),
                new Point(5, 52),
                new Point(12, 60),
                new Point(20, 30),

            };
        }

        public override void Draw(string color, LineStyle lineStyle)
        {
            base.Draw(color, lineStyle);

            this.ConsoleGraphics.DrawPolygon(color, lineStyle, points);

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
