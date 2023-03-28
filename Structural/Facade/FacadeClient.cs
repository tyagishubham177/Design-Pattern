using DesignPatternsApp.Structural.Facade.RealLife;
using DesignPatternsApp.Structural.Facade.Theory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Structural.Facade
{
    internal class FacadeClient
    {
        internal static void StartRealLife()
        {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            
            Console.WriteLine("\n" + customer.Name + "'s mortgage has been " + (eligible ? "Approved" : "Rejected"));
        }

        internal static void StartTheory()
        {
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            FacadeClass facade = new FacadeClass(subsystem1, subsystem2);
            ClientCode(facade);
        }

        private static void ClientCode(FacadeClass facade)
        {
            Console.Write(facade.Operation());
        }
    }
}
