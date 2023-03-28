using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife1
{
    internal interface ICarnivore : IAnimal
    {
        string Eat(IHerbivore herbivore);
    }
}
