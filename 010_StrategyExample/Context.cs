using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_StrategyExample
{
    internal class Context
    {

        int[] data = { 2, 1, 3, 5, 4, 6, 9, 8, 7 };

        public void Sort(SortStrategy sortStrategy)
        {
            sortStrategy.Sort(ref data);
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = data.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = data[i];
                data[i] = data[j];
                data[j] = temp;
            }
        }

        public void PrintArray()
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}