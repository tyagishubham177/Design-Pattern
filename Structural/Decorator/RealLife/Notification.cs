using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Decorator.RealLife
{
    internal abstract class Notification
    {
        public abstract void Send(string message);
    }
}
