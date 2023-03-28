using DesignPatternsApp.Structural.Decorator.RealLife;
using DesignPatternsApp.Structural.Decorator.Theory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Decorator
{
    internal class DecoratorClient
    {
        internal static void StartRealLife()
        {
            Notification simpleNotification = new SimpleNotification();
            simpleNotification.Send("Hello, World!");

            Console.WriteLine();

            Notification decoratedNotification = new PushNotification(new SMSNotification(new EmailNotification(new SimpleNotification())));
            decoratedNotification.Send("Critical issue!");
        }

        internal static void StartTheory()
        {
            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            ClientCode(simple);
            Console.WriteLine();

            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(new ConcreteDecoratorA(simple));
            Console.WriteLine("Client: Now I've got a decorated component:");
            ClientCode(decorator2);
        }

        private static void ClientCode(IComponent component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
