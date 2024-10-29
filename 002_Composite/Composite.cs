using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _002_Composite
{
    public class Composite : Component
    {
        ArrayList nodes = new ArrayList();

        public Composite(string name) : base(name) { }

        public override void Add(Component component)
        {
            nodes.Add(component);
        }

        public override Component? GetChild(int index)
        {
            return nodes[index] as Component;
        }

        public override void Operation()
        {
            Console.WriteLine((Name == "File") ? (Name) : ("   " + Name));
            foreach (Component component in nodes)
            {
                component.Operation();
            }
        }

        public override void Remove(Component component)
        {
            nodes.Remove(component);
        }
    }
}
