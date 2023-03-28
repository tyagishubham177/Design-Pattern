using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DesignPatternsApp.Structural.Decorator.Theory
{
    internal class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}
