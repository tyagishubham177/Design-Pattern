using DesignPatternsApp.Creational.Prototype.RealLife;
using DesignPatternsApp.Creational.Prototype.Theory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.Creational.Prototype
{
    internal class PrototypeClient
    {
        internal static void StartRealLife()
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);

            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);

            // User clones selected colors
            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;

            Console.WriteLine(string.Format("Orig Color :{0}, Cloned Color :{1}", colormanager["red"].ToString(), color1.ToString()));
            Console.WriteLine(string.Format("Orig Color :{0}, Cloned Color :{1}", colormanager["peace"].ToString(), color2.ToString()));
        }

        internal static void StartTheory()
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);
        }
    }
}
