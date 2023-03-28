using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Observer.Theory
{
    internal interface IObserver
    {
        void Update(ISubject subject);
    }
}
