using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace _011_Observer
{
    internal abstract class Subject
    {
        ArrayList observers = new ArrayList();


        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {

            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

    }
}
