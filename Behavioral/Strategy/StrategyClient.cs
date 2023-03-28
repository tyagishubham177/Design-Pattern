using DesignPatternsApp.Behavioral.Strategy.RealLife;
using DesignPatternsApp.Behavioral.Strategy.Theory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Strategy
{
    internal class StrategyClient
    {
        internal static void StartRealLife()
        {
            CityNavigationSystem navigationSystem = new CityNavigationSystem();

            navigationSystem.SetRouteStrategy(new PublicTransportationStrategy());
            Console.WriteLine(navigationSystem.GetRoute("Delhi", "Gurugram"));
            
            navigationSystem.SetRouteStrategy(new PrivateTransportation());
            Console.WriteLine(navigationSystem.GetRoute("Delhi", "Gurugram"));
        }

        internal static void StartTheory()
        {
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}
