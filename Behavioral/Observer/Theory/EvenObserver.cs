using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Observer.Theory
{
    internal class EvenObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State % 2 == 0)
            {
                Console.WriteLine("ConcreteObserverA: Even is good for me.");
            }
            else
            {
                Console.WriteLine("ConcreteObserverA: Listening but not doing anything");
            }
        }
    }
}
