using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Adapter
{
    public class Adapter : ITarget
    {
        Adaptee adaptee = new Adaptee();
        
        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
