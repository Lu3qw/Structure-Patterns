﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Bridge
{
    public class DashLine : LineStyle
    {
        public override string GetLineStyle()
        {
            return "DashLineStyle";
        }
    }
}
