using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife1
{
    internal class AmericaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
