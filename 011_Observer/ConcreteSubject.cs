using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Observer
{
    internal class ConcreteSubject : Subject
    {
        public string State { get; set; } = string.Empty;
    }
}
