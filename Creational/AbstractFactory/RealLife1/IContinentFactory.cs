using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife1
{
    internal interface IContinentFactory
    {
        IHerbivore CreateHerbivore();
        ICarnivore CreateCarnivore();
    }
}
