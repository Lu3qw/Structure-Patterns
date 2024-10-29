using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_StrategyExample
{
    internal class BubbleSort : SortStrategy
    {
        public override void Sort(ref int[] data)
        {
            var n = data.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (data[j] > data[j + 1])
                    {
                        var tempVar = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tempVar;
                    }
        }
    }
}
