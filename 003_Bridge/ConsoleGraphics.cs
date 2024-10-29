using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Bridge
{
    public class ConsoleGraphics
    {
        public void DrawPolygon(string color, LineStyle lineStyle, Point[] points)
        {
            Console.WriteLine("Draw Polygon");
        }

        public void DrawRectangle(string color, LineStyle lineStyle, Point location, Size size)
        {
            Console.WriteLine("Draw Rectangle");
        }

        public void DrawTriangle(string color, LineStyle lineStyle, Point[] points)
        {
            Console.WriteLine("Draw Triangle");
        }
    }
}
