using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Observer.Theory
{
    internal class OddObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            
            if ((subject as Subject).State % 2 != 0)
            {
                Console.WriteLine("ConcreteObserverB: Odd is good for me.");
            }
            else
            {
                Console.WriteLine("ConcreteObserverB: Listening but not doing anything");
            }
        }
    }
}
