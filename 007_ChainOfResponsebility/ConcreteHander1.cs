using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ChainOfResponsebility
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
            {
                Console.WriteLine("One");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
