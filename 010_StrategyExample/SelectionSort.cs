using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_StrategyExample
{
    internal class SelectionSort : SortStrategy
    {
        public override void Sort(ref int[] data)
        {
            var arrayLength = data.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (data[j] < data[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = data[smallestVal];
                data[smallestVal] = data[i];
                data[i] = tempVar;
            }
        }
    }
}
