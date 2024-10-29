using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Bridge
{
    public class Context
    {
        public void Draw(Shape shape, LineStyle style, string color)
        {
            shape.Draw(color, style);
        }
    }
}
