using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Decorator.RealLife
{
    internal class NotificationDecorator : Notification
    {
        protected Notification _notification;

        public NotificationDecorator(Notification notification)
        {
            _notification = notification;
        }

        public override void Send(string message)
        {
            _notification.Send(message);
        }
    }
}
