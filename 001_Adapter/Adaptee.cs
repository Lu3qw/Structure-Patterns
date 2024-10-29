using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Adapter
{
    public sealed class Adaptee
    {
        public void SpecificRequest()
        {

            Console.WriteLine("Specific Request.");

        }
    }
}
