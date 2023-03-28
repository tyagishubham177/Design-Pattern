using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsApp.FactoryMethod.Class;
using DesignPatternsApp.FactoryMethod.RealLife1;

namespace DesignPatternsApp.FactoryMethod
{
    internal static class FactoryMethodClient
    {
        public static void StartTheory()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        public static void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," + Environment.NewLine +
                "but it still works." + Environment.NewLine + creator.SomeOperation());
        }

        public static void StartRealLife()
        {
            List<Document> documents = new List<Document>();
            documents.Add(new Resume());
            documents.Add(new Report());

            foreach (Document document in documents)
            {
                Console.WriteLine("For the document type : " + document.GetType().Name);
                foreach (IPage page in document.Pages)
                {
                    Console.WriteLine(page.GetDescription());
                }
            }
        }
    }
}
