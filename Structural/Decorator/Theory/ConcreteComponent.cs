using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DesignPatternsApp.Structural.Decorator.Theory
{
    internal class ConcreteComponent : IComponent
    {
        public string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
