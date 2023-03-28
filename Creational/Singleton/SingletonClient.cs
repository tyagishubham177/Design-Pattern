using DesignPatternsApp.Creational.Singleton.RealLife1;
using DesignPatternsApp.Creational.Singleton.Theory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternsApp.Creational.Singleton
{
    internal class SingletonClient
    {
        internal static void StartRealLife()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();
            
            // Confirm these are the same instance
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }
            
            // Next, load balance 15 requests for a server
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }
        }

        internal static void StartTheory()
        {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            TheorySingleton singleton = TheorySingleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
