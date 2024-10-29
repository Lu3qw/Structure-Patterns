using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Composite
{
    public class Leaf : Component
    {


        public Leaf(string name) : base(name) { }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override Component GetChild(int index)
        {
            throw new NotImplementedException();
        }

        public override void Operation()
        {
            Console.WriteLine("     " + Name);
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
