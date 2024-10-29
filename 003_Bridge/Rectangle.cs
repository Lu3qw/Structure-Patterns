using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Bridge
{
    public class Rectanle : Shape
    {

        Point location;
        Size size;

        public Rectanle()
        {
            location = new Point(10, 20);
            size = new Size(100, 200);
        }


        public override void Draw(string color, LineStyle lineStyle)
        {
            base.Draw(color, lineStyle);

            this.ConsoleGraphics.DrawRectangle(color, lineStyle, location, size);

            this.PrintShapeInfo();
        }

        public override void PrintShapeInfo()
        {
            base.PrintShapeInfo();

            Console.WriteLine(location);
            Console.WriteLine(size);
        }


    }
}
