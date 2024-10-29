using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Bridge
{
    public abstract class LineStyle
    {
        public virtual string GetLineStyle()
        {
            return "DefaultLineStyle";
        }
    }
}
