using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsApp.AbstractFactory.RealLife1
{
    internal interface IAnimal
    {
        string Name { get; set; }

        string GetDescription();
    }
}
