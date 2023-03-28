using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Observer.Theory
{
    internal interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
