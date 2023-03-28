using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.FactoryMethod.Class
{
    internal class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "This is Concrete Prod 1";
        }
    }
}
