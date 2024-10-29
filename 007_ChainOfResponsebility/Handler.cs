using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ChainOfResponsebility
{
    public abstract class Handler
    {
        public Handler? Successor { get; set; }

        public abstract void HandleRequest(int request);
    }
}
