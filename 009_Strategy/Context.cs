using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Strategy
{
    internal class Context
    {
        Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextAlgorithm()
        {
            strategy.Algorithm();
        }
    }
}
