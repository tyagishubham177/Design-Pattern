using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.Theory
{
    internal class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of product A1";
        }
    }
}
