using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.FactoryMethod.Class
{
    internal class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
