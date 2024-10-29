using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Bridge
{
    public class SolidLine :LineStyle
    {
        public override string GetLineStyle()
        {
            return "SolidLineStyle";
        }
    }
}
