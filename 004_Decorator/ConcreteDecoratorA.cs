using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        string addState = "Some State";

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(addState);
        }

    }
}
