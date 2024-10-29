using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Observer
{
    internal class ConcreteObserver : Observer
    {
        public string ObserverState { get; set; }

        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            ObserverState = subject.State;
        }
    }
}
