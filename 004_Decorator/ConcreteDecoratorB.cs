using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        void AddBehaviour()
        {
            Console.WriteLine("Some Behaviour");
        }

        public override void Operation()
        {
            base.Operation();
            AddBehaviour();
        }
    }
}
