using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Bridge
{
    public abstract class Shape
    {
        protected string Line { get; set; } = string.Empty;

        protected string Color { get; set; } = string.Empty;

        protected ConsoleGraphics ConsoleGraphics { get; set; } = new ConsoleGraphics();

        public virtual void Draw(string color, LineStyle lineStyle)
        {
            this.Line = lineStyle.GetLineStyle();
            this.Color = color;
        }

        public virtual void PrintShapeInfo()
        {
            Console.WriteLine(this.Color);
            Console.WriteLine(this.Line);
        }
    }
}
