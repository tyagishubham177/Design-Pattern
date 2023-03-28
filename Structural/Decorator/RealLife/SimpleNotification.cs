using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Decorator.RealLife
{
    internal class SimpleNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine($"Sending simple notification: {message}");
        }
    }
}
