using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.Theory
{
    internal class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of product B1";
        }

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            string result = collaborator.UsefulFunctionA();
            return "The result of B1 collaborating with " + result;
        }
    }
}
