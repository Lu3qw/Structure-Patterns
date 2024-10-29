using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Decorator
{
    public abstract class Decorator : Component
    {
        public Component Component { get; set; }

        public override void Operation()
        {
            if (Component != null) 
            {
                Component.Operation();
            }
        }
    }
}
