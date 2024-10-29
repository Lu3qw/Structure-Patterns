using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_StrategyExample
{
    internal abstract class SortStrategy
    {
        public abstract void Sort(ref int[] data);
    }
}
