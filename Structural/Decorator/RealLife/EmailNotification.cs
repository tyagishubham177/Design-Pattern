using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Decorator.RealLife
{
    internal class EmailNotification : NotificationDecorator
    {
        public EmailNotification(Notification notification) : base(notification) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("Sending email...");
        }
    }
}
