using DesignPatternsApp.Behavioral.Observer.RealLife;
using DesignPatternsApp.Behavioral.Observer.Theory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Behavioral.Observer
{
    internal class ObserverClient
    {
        internal static void StartRealLife()
        {
            Random random = new Random();

            IInvestor goodInvestor = new GoodInvestor();
            IInvestor badInvestor = new BadInvestor();

            IBMStock ibm = new IBMStock("IBM", 120.00);
            ibm.Attach(goodInvestor);
            ibm.Attach(badInvestor);

            // Fluctuating prices will notify investors
            ibm.Price = random.Next(10, 200);
            ibm.Price = random.Next(10, 200);
            ibm.Price = random.Next(10, 200);
            ibm.Price = random.Next(10, 200);

            ibm.Detach(badInvestor);

            // Fluctuating prices will notify only good investors
            ibm.Price = random.Next(10, 200);
            ibm.Price = random.Next(10, 200);
        }

        internal static void StartTheory()
        {
            var subject = new Subject();
            var evenObserver = new EvenObserver();
            subject.Attach(evenObserver);

            var oddObserver = new OddObserver();
            subject.Attach(oddObserver);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(oddObserver);

            subject.SomeBusinessLogic();
        }
    }
}
