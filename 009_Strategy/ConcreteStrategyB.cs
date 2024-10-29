using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Strategy
{
    internal class ConcreteStrategyB : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("Strategy: ConcreteStrategyB");
        }
    }
}
