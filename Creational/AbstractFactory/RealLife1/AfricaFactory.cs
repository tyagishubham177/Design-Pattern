using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife1
{
    internal class AfricaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
